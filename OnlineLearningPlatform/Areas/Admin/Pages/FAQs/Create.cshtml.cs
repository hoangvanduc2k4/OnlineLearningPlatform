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
    public class CreateModel : PageModel
    {
        private readonly IFAQsService _faqsService;
        private readonly IHubContext<CRUDHub> _hub;
        public CreateModel(IFAQsService faqsService, IHubContext<CRUDHub> hub)
        {
            _faqsService = faqsService;
            _hub = hub;
        }
        [BindProperty]
        public FAQ FAQ { get; set; } = new FAQ();

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            FAQ.CreatedAt = DateTime.Now;
            await _faqsService.AddAsync(FAQ);
            await _hub.Clients.All.SendAsync("FAQCreated", new
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
