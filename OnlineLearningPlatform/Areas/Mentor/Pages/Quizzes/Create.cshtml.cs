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
    public class CreateModel : PageModel
    {
        private readonly IQuizService _quizService;
        private readonly OnlineLearningDBContext _context;
        private readonly IHubContext<CRUDHub> _hub;

        public CreateModel(IQuizService quizService, OnlineLearningDBContext context, IHubContext<CRUDHub> hub)
        {
            _quizService = quizService;
            _context = context;
            _hub = hub;
        }

        [BindProperty]
        public QuizViewModel Quiz { get; set; }

        public SelectList AvailableModules { get; set; }

        public void OnGet()
        {
            AvailableModules = new SelectList(_context.Modules.ToList(), "ModuleId", "ModuleName");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            AvailableModules = new SelectList(_context.Modules.ToList(), "ModuleId", "ModuleName");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _quizService.CreateQuizAsync(Quiz);
            await _hub.Clients.All.SendAsync("loadQuizzes");
            TempData["SuccessMessage"] = "Quiz created successfully.";
            return RedirectToPage("./Index");
        }
    }
}
