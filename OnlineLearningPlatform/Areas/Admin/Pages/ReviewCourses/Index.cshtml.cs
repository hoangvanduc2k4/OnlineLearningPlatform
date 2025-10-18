using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;

namespace OnlineLearningPlatform.Areas.Admin.Pages.ReviewCourses
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ICourseService _courseService;

        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IPagedList<Course> PendingCourses { get; set; }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 10)
        {
            PendingCourses = await _courseService.GetCoursesByStatusPagedAsync(CourseStatus.Pending, pageNumber, pageSize);
        }
    }
}