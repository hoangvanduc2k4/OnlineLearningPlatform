using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Categories
{
    [Authorize(Roles = "Admin")]

    public class IndexModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public IndexModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IPagedList<Category> Categories { get; set; }
        public string SearchTerm { get; set; }
        public int PageSize { get; set; } = 5;

        public async Task OnGetAsync(int pageNumber = 1, string? searchTerm = null)
        {
            Categories = await _categoryService.GetCategoryPagedAdminAsync(pageNumber, PageSize, searchTerm);
            SearchTerm = searchTerm ?? string.Empty;
        }


        public async Task OnPostDeleteAsync(int id, int pageNumber = 1, int pageSize = 5, string? searchTerm = null)
        {
            Category category = await _categoryService.GetCategoryByIdAsync(id);
            if (category != null)
            {
                await _categoryService.DeleteCategoryAsync(category);
            }
            Categories = await _categoryService.GetCategoryPagedAdminAsync(pageNumber, pageSize, searchTerm);
            SearchTerm = searchTerm;
            PageSize = pageSize;
            TempData["SuccessMessage"] = "Deleted successfully.";
        }
    }
}
