using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;

namespace OnlineLearningPlatform.Areas.Admin.FAQs
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly IFAQsService _faqsService;
        private readonly IHubContext<CRUDHub> _hub;
        public IndexModel(IFAQsService faqsService, IHubContext<CRUDHub> hub)
        {
            _faqsService = faqsService;
            _hub = hub;
        }

        public IPagedList<FAQ> PagedFAQs { get; set; }
        public string SearchTerm { get; set; }
        public int PageSize { get; set; }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 3, string? searchTerm = null)
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
            await _hub.Clients.All.SendAsync("FAQDeleted", faq.FaqId);
            TempData["SuccessMessage"] = "Deleted successfully.";
        }
    }

}
