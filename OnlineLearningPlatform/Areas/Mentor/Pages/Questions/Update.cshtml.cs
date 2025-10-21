using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Questions
{
    public class UpdateModel : PageModel
    {
        private readonly IQuestionService _questionService;

        public UpdateModel(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [BindProperty]
        public QuestionWithOptionsViewModel Question { get; set; }

        [BindProperty(SupportsGet = true)]
        public long QuizId { get; set; }

        public async Task<IActionResult> OnGetAsync(long questionId, long quizId)
        {
            QuizId = quizId;
            Question = await _questionService.GetQuestionWithOptionsById(questionId);

            if (Question == null)
            {
                TempData["ErrorMessage"] = "Question not found!";
                return RedirectToPage("Index", new { quizId });
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
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

            // Redirect quay lại danh sách câu hỏi của quiz hiện tại
            return RedirectToPage("Index", new { quizId = Question.QuizId });
        }
    }
}
