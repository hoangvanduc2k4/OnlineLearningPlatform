using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;

namespace OnlineLearningPlatform.Areas.Admin.Pages.ReviewCourses
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ICourseService _courseService;
        private readonly IHubContext<CRUDHub> _hub;
        public IndexModel(ICourseService courseService, IHubContext<CRUDHub> hub)
        {
            _courseService = courseService;
            _hub = hub;
        }

        public IPagedList<Course> PendingCourses { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortBy { get; set; }
        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 10)
        {
            PendingCourses = await _courseService.GetCoursesByStatusPagedAsync(
                CourseStatus.Pending,
                pageNumber,
                pageSize,
                SearchTerm,
                SortBy
            );
        }
    }
}