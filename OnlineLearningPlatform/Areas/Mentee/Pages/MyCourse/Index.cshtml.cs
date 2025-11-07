using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using System.Security.Claims;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Areas.Mentee.Pages.MyCourse
{
    public class IndexModel : PageModel
    {
        private readonly ICourseEnrollmentService _courseEnrollmentService;
        public IPagedList<CourseViewModel> PagedCourses { get; set; } = new List<CourseViewModel>().ToPagedList(1, 10);
        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }

        public IndexModel(ICourseEnrollmentService courseEnrollmentService)
        {
            _courseEnrollmentService = courseEnrollmentService;
        }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 10)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId)) return;
            PagedCourses = await _courseEnrollmentService.GetEnrolledCoursesPagedAsync(userId, pageNumber, pageSize, SearchTerm);
        }
    }
}
