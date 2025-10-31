using MailKit.Search;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow.ValueContentAnalysis;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Questions
{
    [Authorize(Roles = "Mentor")]
    public class IndexModel : PageModel
    {
        UserManager<User> _userManager;
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;
        private readonly IHubContext<CRUDHub> _hub;

        public IndexModel(UserManager<User> userManager, IQuestionService questionService, IQuizService quizService, IHubContext<CRUDHub> hub)
        {
            _questionService = questionService;
            _quizService = quizService;
            _hub = hub;
            _userManager = userManager;
        }
        public long QuizId { get; set; }
        public string QuizName { get; set; } = "";
        public IPagedList<QuestionWithOptionsViewModel> PagedQuestions { get; set; }
        public int PageSize { get; set; } = 2;
        public string SearchTerm { get; set; }

        public IEnumerable<QuestionWithOptionsViewModel> Questions { get; set; }
        public async Task OnGetAsync(long quizId, int? pageNumber, int? pageSize, string searchTerm)
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            try
            {
                PageSize = pageSize ?? 2;
                SearchTerm = searchTerm?.ToLower() ?? "";
                QuizId = quizId;

                var quiz = await _quizService.GetQuizByIdAsync(quizId, mentorId);
                if (quiz == null)
                {
                    TempData["ErrorMessage"] = "Quiz not found!";
                    return;
                }

                QuizName = quiz.QuizName;
                int page = pageNumber ?? 1;

                Questions = await _questionService.GetAllQuestionsWithOptionsByQuizIdAsync(
                    quiz.QuizId,
                    searchTerm
                );

                PagedQuestions = Questions.ToPagedList(page, PageSize);
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message; 
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while loading the question list.";
            }
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
                await _hub.Clients.All.SendAsync("loadQuestions");
                TempData["SuccessMessage"] = "Question deleted successfully.";
            }

            return RedirectToPage("./Index", new { quizId, pageNumber, pageSize, searchTerm });
        }


    }
}
