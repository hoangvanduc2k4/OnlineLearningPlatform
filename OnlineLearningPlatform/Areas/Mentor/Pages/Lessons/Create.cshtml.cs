using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Lessons
{
    [Authorize(Roles = "Mentor")]
    public class CreateModel : PageModel
    {
        private readonly ILessonService _lessonService;
        private readonly IModuleService _moduleService;
        private readonly ICourseService _courseService;
        private readonly UserManager<User> _userManager;

        public CreateModel(
            ILessonService lessonService,
            IModuleService moduleService,
            ICourseService courseService,
            UserManager<User> userManager)
        {
            _lessonService = lessonService;
            _moduleService = moduleService;
            _courseService = courseService;
            _userManager = userManager;
        }

        [BindProperty]
        public LessonInputViewModel LessonVM { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long moduleId, long courseId)
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(mentorId)) return Forbid();
            if (courseId == 0 || moduleId == 0) return NotFound();

            var course = await _courseService.GetCourseByIdAndMentorAsync(courseId, mentorId);
            var module = await _moduleService.GetModuleForEditAsync(moduleId, mentorId);

            if (course == null || module == null || module.CourseId != course.CourseId)
            {
                return Forbid();
            }

            ViewData["CourseName"] = course.CourseName;
            ViewData["ModuleName"] = module.ModuleName;
            ViewData["CourseId"] = courseId;
            ViewData["ModuleId"] = moduleId;

            LessonVM = new LessonInputViewModel
            {
                ModuleId = moduleId,
                CourseId = courseId
            };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var course = await _courseService.GetCourseByIdAndMentorAsync(LessonVM.CourseId, mentorId);
                var module = await _moduleService.GetModuleForEditAsync(LessonVM.ModuleId, mentorId);

                ViewData["CourseName"] = course?.CourseName;
                ViewData["ModuleName"] = module?.ModuleName;
                ViewData["CourseId"] = LessonVM.CourseId;
                ViewData["ModuleId"] = LessonVM.ModuleId;

                return Page();
            }

            await _lessonService.CreateLessonAsync(LessonVM);


            //return RedirectToPage("/Courses/Manage", new { area = "Mentor", id = LessonVM.CourseId });
            return RedirectToPage("/Courses/Manage", new
            {
                area = "Mentor",
                id = LessonVM.CourseId,
                moduleId = LessonVM.ModuleId
            });
        }
    }
}
