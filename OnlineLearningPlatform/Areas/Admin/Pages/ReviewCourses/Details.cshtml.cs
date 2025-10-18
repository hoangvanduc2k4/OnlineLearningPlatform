using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.ReviewCourses
{
    [Authorize(Roles = "Admin")]
    public class DetailsModel : PageModel
    {
        private readonly ICourseService _courseService;

        public DetailsModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public Course CourseToReview { get; set; }

        [BindProperty]
        public ReviewInputModel ReviewInput { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            CourseToReview = await _courseService.GetCourseForReviewAsync(id);
            if (CourseToReview == null || CourseToReview.Status != CourseStatus.Pending)
            {
                TempData["ErrorMessage"] = "Course not found or is no longer pending review.";
                return RedirectToPage("./Index");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostApproveAsync(long id)
        {
            var adminId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(adminId)) return Unauthorized();

            await _courseService.ReviewCourseAsync(id, adminId, ReviewStatus.Approved, ReviewInput.ReviewNotes);

            TempData["SuccessMessage"] = "Course has been approved.";
            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostRejectAsync(long id)
        {
            if (string.IsNullOrWhiteSpace(ReviewInput.ReviewNotes))
            {
                ModelState.AddModelError("ReviewInput.ReviewNotes", "Review notes are required when rejecting a course.");
                CourseToReview = await _courseService.GetCourseForReviewAsync(id);
                return Page();
            }

            var adminId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(adminId)) return Unauthorized();

            await _courseService.ReviewCourseAsync(id, adminId, ReviewStatus.Rejected, ReviewInput.ReviewNotes);

            TempData["SuccessMessage"] = "Course has been rejected.";
            return RedirectToPage("./Index");
        }
    }
}