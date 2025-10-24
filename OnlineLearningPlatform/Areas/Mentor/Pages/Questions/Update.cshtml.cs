using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Questions
{
    [Authorize(Roles = "Mentor")]
    public class UpdateModel : PageModel
    {
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;
        private readonly IHubContext<CRUDHub> _hub;

        public UpdateModel(IQuestionService questionService, IQuizService quizService, IHubContext<CRUDHub> hub)
        {
            _questionService = questionService;
            _quizService = quizService;
            _hub = hub;
        }

        [BindProperty]
        public QuestionWithOptionsViewModel Question { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public long QuizId { get; set; }

        public string QuizName { get; set; } = string.Empty;

        public async Task<IActionResult> OnGetAsync(long questionId, long quizId)
        {
            QuizId = quizId;

            // Lấy question theo ID
            var question = await _questionService.GetQuestionWithOptionsById(questionId);
            if (question == null)
            {
                TempData["ErrorMessage"] = "Question not found!";
                return RedirectToPage("Index", new { quizId });
            }

            Question = question;
            var Quiz = await _quizService.GetQuizByIdAsync(quizId);
            QuizName = Quiz?.QuizName ?? string.Empty;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var Quiz = await _quizService.GetQuizByIdAsync(QuizId);
                QuizName = Quiz?.QuizName ?? string.Empty;
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
    }
}
