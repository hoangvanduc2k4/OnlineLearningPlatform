using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Controllers
{
    public class InstructorsController : Controller
    {

        private readonly IUserService _userService;
        private readonly ICourseService _courseService;

        public InstructorsController(IUserService userService, ICourseService courseService)
        {
            _userService = userService;
            _courseService = courseService;
        }

        public async Task<IActionResult> Index(
            string? searchString,
            int page = 1,
            string? sortBy = "name",
            string? orderBy = "desc")
        {
            int pageSize = 8;
            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSortBy"] = sortBy;
            ViewData["CurrentOrderBy"] = orderBy;

            var pagedModel = await _userService.GetPaginatedMentorsAsync(
                searchString,
                page,
                pageSize,
                sortBy,
                orderBy);

            return View(pagedModel);
        }

    }
}
