using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Categories
{
    [Authorize(Roles = "Admin")]
    public class UpdateModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public UpdateModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            Category = await _categoryService.GetCategoryByIdAsync(id);
            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _categoryService.UpdateCategoryAsync(Category);
            return RedirectToPage("./Index");
        }
    }
}
