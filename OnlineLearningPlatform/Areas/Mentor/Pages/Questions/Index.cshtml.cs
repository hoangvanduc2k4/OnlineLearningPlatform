using MailKit.Search;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow.ValueContentAnalysis;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Questions
{
    [Authorize(Roles = "Mentor")]
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
        public IPagedList<QuestionWithOptionsViewModel> PagedQuestions { get; set; }
        public int PageSize { get; set; } = 2;
        public string SearchTerm { get; set; }

        public IEnumerable<QuestionWithOptionsViewModel> Questions { get; set; }
        public async Task OnGetAsync(long quizId, int? pageNumber, int? pageSize, string searchTerm)
        {
            PageSize = pageSize ?? 2;
            SearchTerm = searchTerm?.ToLower() ?? "";

            QuizId = quizId;

            var quiz = await _quizService.GetQuizByIdAsync(quizId);

            if (quiz == null)
            {
                TempData["ErrorMessage"] = "Quiz not found!";
                return;
            }

            QuizName = quiz.QuizName;
            int page = pageNumber ?? 1;

            Questions = await _questionService.GetAllQuestionsWithOptionsByQuizIdAsync(quiz.QuizId, searchTerm);
            PagedQuestions = Questions.ToPagedList(page, PageSize);

        }

        public async Task<IActionResult> OnPostDeleteAsync(long questionId, long quizId, int? pageNumber, int? pageSize, string searchTerm)
        {
            var question = await _questionService.GetQuestionWithOptionsById(questionId);
            if (question == null)
            {
                TempData["ErrorMessage"] = "Question not found!";
            }
            else
            {
                await _questionService.DeleteQuestionAsync(questionId);
                TempData["SuccessMessage"] = "Question deleted successfully.";
            }

            return RedirectToPage("./Index", new { quizId, pageNumber, pageSize, searchTerm });
        }


    }
}
