using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;

namespace OnlineLearningPlatform.Areas.Admin.FAQs
{
    [Authorize(Roles = "ADMIN")]
    public class IndexModel : PageModel
    {
        private readonly IFAQsService _faqsService;

        public IndexModel(IFAQsService faqsService)
        {
            _faqsService = faqsService;
        }

        public IPagedList<FAQ> PagedFAQs { get; set; }
        public string SearchTerm { get; set; }
        public int PageSize { get; set; }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 5, string? searchTerm = null)
        {
            PagedFAQs = await _faqsService.GetFAQsPagedAdminAsync(pageNumber, pageSize, searchTerm);
            SearchTerm = searchTerm;
            PageSize = pageSize;
        }

        public async Task OnPostDeleteAsync(int id, int pageNumber = 1, int pageSize = 5, string? searchTerm = null)
        {
            FAQ faq = await _faqsService.GetByIdAsync(id);
            if (faq != null)
            {
                await _faqsService.DeleteAsync(faq);
            }
            PagedFAQs = await _faqsService.GetFAQsPagedAdminAsync(pageNumber, pageSize, searchTerm);
            SearchTerm = searchTerm;
            PageSize = pageSize;
            TempData["SuccessMessage"] = "Deleted successfully.";
        }
    }

}
