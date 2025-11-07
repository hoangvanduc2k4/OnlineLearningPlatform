using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Questions
{
    [Authorize(Roles = "Mentor")]
    public class UpdateModel : PageModel
    {
        UserManager<User> _userManager;
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;
        private readonly IHubContext<CRUDHub> _hub;

        private readonly ICourseService _courseService;
        private readonly IModuleService _moduleService;
        public UpdateModel(UserManager<User> userManager, IQuestionService questionService, IQuizService quizService, IHubContext<CRUDHub> hub, ICourseService courseService, IModuleService moduleService)
        {
            _questionService = questionService;
            _quizService = quizService;
            _hub = hub;
            _userManager = userManager;
            _courseService = courseService;
            _moduleService = moduleService;
        }

        [BindProperty]
        public QuestionWithOptionsViewModel Question { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public long QuizId { get; set; }

        public string QuizName { get; set; } = string.Empty;

        public async Task<IActionResult> OnGetAsync(long questionId, long quizId)
        {
            QuizId = quizId;

            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            try
            {
                // Kiểm tra quyền sở hữu quiz trước
                var quiz = await _quizService.GetQuizByIdAsync(quizId, mentorId);
                if (quiz == null)
                {
                    TempData["ErrorMessage"] = "Quiz not found!";
                    return RedirectToPage("Index", new { quizId });
                }

                // Lấy question theo ID
                var question = await _questionService.GetQuestionWithOptionsById(questionId);
                if (question == null)
                {
                    TempData["ErrorMessage"] = "Question not found!";
                    return RedirectToPage("Index", new { quizId });
                }

                // Gán dữ liệu cho page
                Question = question;
                QuizName = quiz.QuizName;
                var module = await _moduleService.GetModuleForEditAsync(quiz.ModuleId, mentorId);
                var course = await _courseService.GetCourseByIdAndMentorAsync(module.CourseId, mentorId);
                if (course != null && module != null)
                {
                    ViewData["CourseName"] = course.CourseName;
                    ViewData["ModuleName"] = module.ModuleName;
                    ViewData["CourseId"] = course.CourseId;
                    ViewData["QuizId"] = quizId;
                }
                return Page();
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message; 
                return RedirectToPage("/Mentor/Quizzes/Index");
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Đã xảy ra lỗi khi tải câu hỏi.";
                return RedirectToPage("/Mentor/Quizzes/Index");
            }
        }


        public async Task<IActionResult> OnPostAsync()
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            try
            {
                // Kiểm tra quyền sở hữu quiz trước khi update
                var quiz = await _quizService.GetQuizByIdAsync(QuizId, mentorId);
                if (quiz == null)
                {
                    TempData["ErrorMessage"] = "Quiz not found!";
                    return RedirectToPage("/Mentor/Quizzes/Index");
                }

                if (!ModelState.IsValid)
                {
                    QuizName = quiz.QuizName;
                    var module = await _moduleService.GetModuleForEditAsync(quiz.ModuleId, mentorId);
                    var course = await _courseService.GetCourseByIdAndMentorAsync(module.CourseId, mentorId);

                    if (course != null && module != null)
                    {
                        ViewData["CourseName"] = course.CourseName;
                        ViewData["ModuleName"] = module.ModuleName;
                        ViewData["CourseId"] = course.CourseId;
                        ViewData["QuizId"] = QuizId;
                    }
                    return Page();
                }

                await _questionService.UpdateQuestionWithOptionsAsync(
                    new QuestionViewModel
                    {
                        QuestionId = Question.QuestionId,
                        QuestionContent = Question.QuestionContent,
                        QuizId = Question.QuizId
                    },
                    Question.Options
                );

                await _hub.Clients.All.SendAsync("loadQuestions");
                TempData["SuccessMessage"] = "Question updated successfully!";
                return RedirectToPage("Index", new { quizId = Question.QuizId });
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message; 
                return RedirectToPage("/Mentor/Quizzes/Index");
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Đã xảy ra lỗi khi cập nhật câu hỏi.";
                return RedirectToPage("/Mentor/Quizzes/Index");
            }
        }

    }
}
