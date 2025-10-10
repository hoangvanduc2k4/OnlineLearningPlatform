using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Controllers
{
    [Area("Mentor")]
    [Authorize(Roles = "Mentor")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        // GET: /Mentor/Course
        public async Task<IActionResult> Index()
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (mentorId == null) return Unauthorized();

            var courses = await _courseService.GetCoursesForMentorAsync(mentorId);
            return View(courses);
        }

        // GET: /Mentor/Course/Create
        public IActionResult Create()
        {
            //  dropdownlist (Levels, Categories) 
            return View(new CourseCreateViewModel());
        }

        // POST: /Mentor/Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (mentorId == null) return Unauthorized();

                var newCourse = new Course
                {
                    CourseName = viewModel.CourseName,
                    Description = viewModel.Description,
                    Price = viewModel.Price
                };

                await _courseService.CreateCourseAsync(newCourse, mentorId);

                // TempData["success"] = "Course created successfully!"; // (Optional) Add a success message
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        // GET: /Mentor/Course/Edit/5
        public async Task<IActionResult> Edit(long id)
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (mentorId == null) return Unauthorized();

            var course = await _courseService.GetCourseByIdAndMentorAsync(id, mentorId);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        // POST: /Mentor/Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, Course course)
        {
            if (id != course.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (mentorId == null) return Unauthorized();

                var success = await _courseService.UpdateCourseAsync(course, mentorId);
                if (!success)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }


    }
}
