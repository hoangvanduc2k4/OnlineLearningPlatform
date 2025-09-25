using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Levels
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly ILevelService _levelService;

        public CreateModel(ILevelService levelService)
        {
            _levelService = levelService;
        }

        [BindProperty]
        public Level Level { get; set; } = new Level { IsDeleted = false };

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _levelService.AddLevelAsync(Level);
            return RedirectToPage("./Index");
        }

    }
}
