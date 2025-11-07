using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Controllers
{
    public class LearnController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ILessonService _lessonService;
        private readonly IQuizService _quizService;
        private readonly IQuestionService _questionService;
        private readonly IQuizResultService _quizResultService;
        private readonly UserManager<OnlineLearningPlatform.Models.Entities.UserPart.User> _userManager;

        public LearnController(ICourseService courseService, UserManager<OnlineLearningPlatform.Models.Entities.UserPart.User> userManager, ILessonService lessonService, IQuizService quizService, IQuestionService questionService, IQuizResultService quizResultService)
        {
            _courseService = courseService;
            _userManager = userManager;
            _lessonService = lessonService;
            _quizService = quizService;
            _questionService = questionService;
            _quizResultService = quizResultService;
        }

        // GET: /Learn/Course/5
        public async Task<IActionResult> Course(int id, long? lessonId = null)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await _courseService.GetCourseDetailsToLearnAsync(id, userId);
            if (model == null || !model.IsEnrolled) return NotFound();

            // Chọn lesson đầu tiên nếu chưa có lessonId
            var firstLesson = model.Modules.SelectMany(m => m.Lessons).OrderBy(l => l.LessonNumber).FirstOrDefault();
            var selectedLesson = lessonId != null
                ? model.Modules.SelectMany(m => m.Lessons).FirstOrDefault(l => l.LessonId == lessonId)
                : firstLesson;
            ViewBag.SelectedLesson = selectedLesson;
            return View(model);
        }

        // GET: /Learn/GetLesson/123
        public async Task<IActionResult> GetLesson(long id)
        {
            var lesson = await _lessonService.GetLessonViewModelByIdAsync(id);
            if (lesson == null) return NotFound();
            return PartialView("_LessonContent", lesson);
        }

        // GET: /Learn/GetQuiz/123
        public async Task<IActionResult> GetQuiz(long id)
        {
            var quiz = await _quizService.GetAllQuizAsync();
            var quizVm = quiz.FirstOrDefault(q => q.QuizId == id);
            if (quizVm == null) return NotFound();
            var questions = await _questionService.GetAllQuestionsWithOptionsByQuizIdAsync(id);
            ViewBag.Quiz = quizVm;
            return PartialView("_QuizContent", questions);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitQuiz([FromBody] QuizSubmitViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null) return Unauthorized();

            var questions = await _questionService.GetAllQuestionsWithOptionsByQuizIdAsync(model.QuizId);
            int total = questions.Count;
            int correct = 0;

            foreach (var q in questions)
            {
                if (model.Answers.TryGetValue(q.QuestionId, out var optId))
                {
                    var correctOption = q.Options.FirstOrDefault(o => o.IsCorrect);
                    if (correctOption != null && correctOption.OptionId == optId)
                        correct++;
                }
            }

            decimal score = total > 0 ? (decimal)correct / total * 100 : 0;

            var quiz = (await _quizService.GetAllQuizAsync()).FirstOrDefault(q => q.QuizId == model.QuizId);
            int passScore = quiz?.PassScore ?? 0;

            // Parse start/end time from client
            DateTime startTime = DateTime.UtcNow, endTime = DateTime.UtcNow;
            if (!string.IsNullOrEmpty(model.StartTime)) DateTime.TryParse(model.StartTime, out startTime);
            if (!string.IsNullOrEmpty(model.EndTime)) DateTime.TryParse(model.EndTime, out endTime);

            // Xử lý xóa kết quả cũ nếu đã đủ 10
            var oldResults = await _quizResultService.GetResultsByUserAndQuizAsync(userId, model.QuizId, 11);
            if (oldResults.Count >= 10)
            {
                var toDelete = oldResults.OrderBy(r => r.CreatedAt).First();
                await _quizResultService.DeleteQuizResultAsync(toDelete);
            }

            var quizResult = new QuizResult
            {
                UserId = userId,
                QuizId = model.QuizId,
                Score = score,
                TotalQuestions = total,
                CorrectAnswers = correct,
                StartTime = startTime,
                EndTime = endTime,
                CreatedAt = DateTime.UtcNow
            };
            await _quizResultService.AddQuizResultAsync(quizResult);

            return Json(new { score, correct, total, pass = score >= passScore });
        }

        // GET: /Learn/GetQuizHistory/123
        public async Task<IActionResult> GetQuizHistory(long id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var history = await _quizResultService.GetResultsByUserAndQuizAsync(userId, id, 10);
            var quizz = await _quizService.GetQuizAsync(id);
            ViewBag.PassScore = quizz.PassScore;
            return PartialView("_QuizHistory", history);
        }
    }
}
