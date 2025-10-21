using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Questions
{
    public class CreateModel : PageModel
    {
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;

        public CreateModel(IQuestionService questionService, IQuizService quizService)
        {
            _questionService = questionService;
            _quizService = quizService;
        }

        [BindProperty]
        public QuestionWithOptionsViewModel Question { get; set; } = new();

        public string QuizName { get; set; } = "";

        // ✅ Nhận quizId từ route
        public async Task<IActionResult> OnGetAsync(long quizId)
        {
            var quiz = await _quizService.GetQuizByIdAsync(quizId);
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

        // ✅ Cần quizId trong route để giữ đúng context khi Post
        public async Task<IActionResult> OnPostAsync(long quizId)
        {
            // Gắn lại quizId (phòng trường hợp bị mất)
            Question.QuizId = quizId;

            if (!ModelState.IsValid)
            {
                var quiz = await _quizService.GetQuizByIdAsync(quizId);
                QuizName = quiz?.QuizName ?? "";
                return Page();
            }

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

            // ✅ Quay lại đúng quiz khi xong
            return RedirectToPage("Index", new { quizId = Question.QuizId });
        }
    }
}
