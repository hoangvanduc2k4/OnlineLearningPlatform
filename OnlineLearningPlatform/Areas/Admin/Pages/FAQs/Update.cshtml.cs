using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.FAQs
{
    [Authorize(Roles = "ADMIN")]
    public class UpdateModel : PageModel
    {
        private readonly IFAQsService _faqsService;

        public UpdateModel(IFAQsService faqsService)
        {
            _faqsService = faqsService;
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

            return RedirectToPage("./Index");
        }
    }
}
