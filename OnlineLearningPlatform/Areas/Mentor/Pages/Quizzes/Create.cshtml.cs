using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Quizzes
{
    public class CreateModel : PageModel
    {
        private readonly IQuizService _quizService;
        private readonly OnlineLearningDBContext _context;

        public CreateModel(IQuizService quizService, OnlineLearningDBContext context)
        {
            _quizService = quizService;
            _context = context;
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

            TempData["SuccessMessage"] = "Quiz created successfully.";
            return RedirectToPage("./Index");
        }
    }
}
