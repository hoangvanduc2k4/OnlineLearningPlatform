using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Quizzes
{
    [Authorize(Roles = "Mentor")]
    public class UpdateModel : PageModel
    {
        private readonly IQuizService _quizService;
        private readonly OnlineLearningDBContext _context;
        private readonly IHubContext<CRUDHub> _hub;

        public UpdateModel(IQuizService quizService, OnlineLearningDBContext context, IHubContext<CRUDHub> hub)
        {
            _quizService = quizService;
            _context = context;
            _hub = hub;
        }

        [BindProperty]
        public QuizViewModel Quiz { get; set; }

        public SelectList AvailableModules { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            var quiz = await _quizService.GetQuizByIdAsync(id);
            if (quiz == null)
            {
                TempData["ErrorMessage"] = "Quiz not found.";
                return RedirectToPage("./Index");
            }

            Quiz = quiz;
            AvailableModules = new SelectList(_context.Modules.ToList(), "ModuleId", "ModuleName", Quiz.ModuleId);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            AvailableModules = new SelectList(_context.Modules.ToList(), "ModuleId", "ModuleName", Quiz.ModuleId);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var existingQuiz = await _quizService.GetQuizByIdAsync(Quiz.QuizId);
            if (existingQuiz == null)
            {
                TempData["ErrorMessage"] = "Quiz not found.";
                return RedirectToPage("./Index");
            }

            existingQuiz.QuizName = Quiz.QuizName;
            existingQuiz.ModuleId = Quiz.ModuleId;
            existingQuiz.QuizTime = Quiz.QuizTime;
            existingQuiz.TimeUnit = Quiz.TimeUnit;
            existingQuiz.PassScore = Quiz.PassScore;

            await _quizService.UpdateQuizAsync(existingQuiz);
            await _hub.Clients.All.SendAsync("loadQuizzes");
            TempData["SuccessMessage"] = "Quiz updated successfully.";
            return RedirectToPage("./Index");
        }
    }
}
