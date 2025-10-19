using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Categories
{
    [Authorize(Roles = "Admin")]
    public class UpdateModel : PageModel
    {
        private readonly ICategoryService _categoryService;
        private readonly IHubContext<CRUDHub> _hub;

        public UpdateModel(ICategoryService categoryService, IHubContext<CRUDHub> hub)
        {
            _categoryService = categoryService;
            _hub = hub;

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
            await _hub.Clients.All.SendAsync("CategoryUpdated", new
            {
                categoryId = Category.CategoryId,
                categoryName = Category.CategoryName,
                isDeleted = Category.IsDeleted
            });
            return RedirectToPage("./Index");
        }
    }
}
