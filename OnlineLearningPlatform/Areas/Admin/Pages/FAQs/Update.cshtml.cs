using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.FAQs
{
    [Authorize(Roles = "Admin")]
    public class UpdateModel : PageModel
    {
        private readonly IFAQsService _faqsService;
        private readonly IHubContext<CRUDHub> _hub;
        public UpdateModel(IFAQsService faqsService, IHubContext<CRUDHub> hub)
        {
            _faqsService = faqsService;
            _hub = hub;
        }

        [BindProperty]
        public FAQ FAQ { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            FAQ = await _faqsService.GetByIdAsync(id);
            if (FAQ == null)
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

            FAQ.UpdatedAt = DateTime.Now;
            await _faqsService.UpdateAsync(FAQ);
            await _hub.Clients.All.SendAsync("LoadFAQs");
            await _hub.Clients.All.SendAsync("FAQUpdated", new
            {
                faqId = FAQ.FaqId,
                question = FAQ.Question,
                answer = FAQ.Answer,
                commonStatus = FAQ.CommonStatus.ToString()
            });
            return RedirectToPage("./Index");
        }
    }
}
