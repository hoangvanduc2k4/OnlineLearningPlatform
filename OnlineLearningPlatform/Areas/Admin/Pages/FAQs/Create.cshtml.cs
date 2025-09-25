using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.FAQs
{
    [Authorize(Roles = "ADMIN")]
    public class CreateModel : PageModel
    {
        private readonly IFAQsService _faqsService;

        public CreateModel(IFAQsService faqsService)
        {
            _faqsService = faqsService;
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

            return RedirectToPage("./Index");
        }
    }
}
