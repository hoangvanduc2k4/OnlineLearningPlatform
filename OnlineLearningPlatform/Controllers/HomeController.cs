using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        public HomeController(ICourseService courseService, IUserService userService, ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _courseService = courseService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var topMentor = _userService.GetTopMentorsByStudentCountAsync(4);
            ViewBag.TopMentors = topMentor.Result;
            var topCourses = _courseService.GetTopNewestCoursesAsync(3);
            ViewBag.TopCourses = topCourses.Result;
            return View();
        }

    }
}
