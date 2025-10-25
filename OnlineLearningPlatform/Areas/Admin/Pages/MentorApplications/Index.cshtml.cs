using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;
using OnlineLearningPlatform.Enums;
using X.PagedList;
using System.Linq;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Areas.Admin.Pages.MentorApplications
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class IndexModel : PageModel
    {
        private readonly IMentorApplicationService _mentorAppService;
        private readonly IUserService _userService;

        public IndexModel(IMentorApplicationService mentorAppService, IUserService userService)
        {
            _mentorAppService = mentorAppService;
            _userService = userService;
        }

        public IPagedList<MentorApplication> PagedApplications { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 10;
        [BindProperty]
        public string? Feedback { get; set; }
        [BindProperty]
        public long SelectedId { get; set; }    
        [BindProperty(SupportsGet = true)]
        public ApplicationStatus? Status { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? PageNumber { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? PageSizeParam { get; set; }
        public string? SuccessMessage { get; set; }
        public string? ErrorMessage { get; set; }

        public async Task OnGetAsync()
        {
            int page = PageNumber ?? 1;
            PageSize = PageSizeParam ?? 10;
            var all = await _mentorAppService.GetAllAsync();
            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                all = all.Where(a => (a.User.FullName != null && a.User.FullName.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase))
                    || (a.User.Email != null && a.User.Email.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase)));
            }
            if (Status.HasValue)
            {
                all = all.Where(a => a.Status == Status.Value);
            }
            PagedApplications = all.OrderByDescending(a => a.SubmittedAt).ToPagedList(page, PageSize);
        }

        public async Task<IActionResult> OnPostApproveAsync(long selectedId, string? feedback, int? pageNumber, int? pageSize, string? searchTerm, ApplicationStatus? status)
        {
            var app = await _mentorAppService.GetByIdAsync(selectedId);
            if (app == null)
            {
                ErrorMessage = "Application not found.";
                await OnGetAsync();
                return Page();
            }
            app.Status = ApplicationStatus.Approved;
            app.Feedback = feedback;
            app.ReviewedAt = DateTime.UtcNow;
            app.AdminReviewerId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            await _mentorAppService.UpdateAsync(app);
            SuccessMessage = "Application approved.";
            return RedirectToPage(new { pageNumber, pageSize, searchTerm, status });
        }

        public async Task<IActionResult> OnPostRejectAsync(long selectedId, string? feedback, int? pageNumber, int? pageSize, string? searchTerm, ApplicationStatus? status)
        {
            var app = await _mentorAppService.GetByIdAsync(selectedId);
            if (app == null)
            {
                ErrorMessage = "Application not found.";
                await OnGetAsync();
                return Page();
            }
            app.Status = ApplicationStatus.Rejected;
            app.Feedback = feedback;
            app.ReviewedAt = DateTime.UtcNow;
            app.AdminReviewerId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            await _mentorAppService.UpdateAsync(app);
            SuccessMessage = "Application rejected.";
            return RedirectToPage(new { pageNumber, pageSize, searchTerm, status });
        }
    }
}
