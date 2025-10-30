using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Questions
{
    [Authorize(Roles = "Mentor")]
    public class CreateModel : PageModel
    {
        UserManager<User> _userManager;
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;
        private readonly IHubContext<CRUDHub> _hub;

        public CreateModel(UserManager<User> userManager,IQuestionService questionService, IQuizService quizService, IHubContext<CRUDHub> hub)
        {
            _questionService = questionService;
            _quizService = quizService;
            _hub = hub;
            _userManager = userManager;
        }

        [BindProperty]
        public QuestionWithOptionsViewModel Question { get; set; } = new();

        public string QuizName { get; set; } = "";

        public async Task<IActionResult> OnGetAsync(long quizId)
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            try
            {
                var quiz = await _quizService.GetQuizByIdAsync(quizId, mentorId);
                if (quiz == null)
                {
                    TempData["ErrorMessage"] = "Quiz not found!";
                    return RedirectToPage("/Mentor/Quizzes/Index");
                }

                Question.QuizId = quizId;
                QuizName = quiz.QuizName;
                Question.Options = new List<OptionsViewModel>();

                return Page();
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message; 
                return RedirectToPage("/Mentor/Quizzes/Index");
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Đã xảy ra lỗi khi tải quiz.";
                return RedirectToPage("/Mentor/Quizzes/Index");
            }
        }


        public async Task<IActionResult> OnPostAsync(long quizId)
        {
            // Gắn lại quizId (phòng trường hợp bị mất)
            Question.QuizId = quizId;

            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            try
            {
                // Kiểm tra quyền sở hữu quiz
                var quiz = await _quizService.GetQuizByIdAsync(quizId, mentorId);
                if (quiz == null)
                {
                    TempData["ErrorMessage"] = "Quiz not found!";
                    return RedirectToPage("/Mentor/Quizzes/Index");
                }

                // Nếu form không hợp lệ, trả về lại trang
                if (!ModelState.IsValid)
                {
                    QuizName = quiz.QuizName;
                    return Page();
                }

                // Thêm câu hỏi mới vào quiz
                await _questionService.CreateQuestionWithOptionsAsync(
                    new QuestionViewModel
                    {
                        QuestionContent = Question.QuestionContent,
                        QuizId = Question.QuizId
                    },
                    Question.Options,
                    new QuizViewModel { QuizId = Question.QuizId }
                );

                TempData["SuccessMessage"] = "Question created successfully.";
                await _hub.Clients.All.SendAsync("loadQuestions");

                return RedirectToPage("Index", new { quizId = Question.QuizId });
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message; 
                return RedirectToPage("/Mentor/Quizzes/Index");
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Đã xảy ra lỗi khi tạo câu hỏi.";
                return RedirectToPage("/Mentor/Quizzes/Index");
            }
        }

    }
}
