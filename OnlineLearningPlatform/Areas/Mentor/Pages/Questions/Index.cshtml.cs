using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Questions
{
    public class IndexModel : PageModel
    {
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;

        public IndexModel(IQuestionService questionService, IQuizService quizService)
        {
            _questionService = questionService;
            _quizService = quizService;
        }
        public long QuizId { get; set; }
        public string QuizName { get; set; } = "";
        public List<QuestionWithOptionsViewModel> Questions { get; set; }
        public async Task OnGetAsync(long quizId)
        {
            QuizId = quizId;

            var quiz = await _quizService.GetQuizByIdAsync(quizId);

            if (quiz == null)
            {
                TempData["ErrorMessage"] = "Quiz not found!";
                return;
            }

            QuizName = quiz.QuizName;

            Questions = await _questionService.GetAllQuestionsWithOptionsByQuizIdAsync(quiz.QuizId);
        }

        public async Task<IActionResult> OnPostDeleteAsync(long questionId, long quizId)
        {
            await _questionService.DeleteQuestionAsync(questionId);
            return RedirectToPage(new { quizId });
        }

    }
}
