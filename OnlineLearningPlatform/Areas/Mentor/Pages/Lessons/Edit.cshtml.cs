using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Lessons
{
    [Authorize(Roles = "Mentor")]
    public class EditModel : PageModel
    {
        private readonly ILessonService _lessonService;
        private readonly IModuleService _moduleService;
        private readonly ICourseService _courseService;
        private readonly UserManager<User> _userManager;

        public EditModel(
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

        public async Task<IActionResult> OnGetAsync(long id)
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);
            if (string.IsNullOrEmpty(mentorId)) return Forbid();

            var lessonViewModel = await _lessonService.GetLessonForEditAsync(id, mentorId);
            if (lessonViewModel == null) return NotFound();

            LessonVM = lessonViewModel;
            var module = await _moduleService.GetModuleForEditAsync(LessonVM.ModuleId, mentorId);
            if (module == null) return Forbid(); 
            var course = await _courseService.GetCourseByIdAndMentorAsync(module.CourseId, mentorId);
            LessonVM.CourseId = module.CourseId;

            ViewData["CourseName"] = course?.CourseName;
            ViewData["ModuleName"] = module?.ModuleName;
            ViewData["CourseId"] = LessonVM.CourseId;
            ViewData["LessonId"] = id; 

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var mentor = await _userManager.GetUserAsync(User);
                var mentorId = await _userManager.GetUserIdAsync(mentor);
                var course = await _courseService.GetCourseByIdAndMentorAsync(LessonVM.CourseId, mentorId);
                var module = await _moduleService.GetModuleForEditAsync(LessonVM.ModuleId, mentorId);

                ViewData["CourseName"] = course?.CourseName;
                ViewData["ModuleName"] = module?.ModuleName;
                ViewData["CourseId"] = LessonVM.CourseId;
                ViewData["LessonId"] = LessonVM.LessonId;

                return Page();
            }

            var mentorIdOnPost = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var success = await _lessonService.UpdateLessonAsync(LessonVM, mentorIdOnPost);

            if (!success) return NotFound();

            TempData["SuccessMessage"] = "Lesson updated successfully.";
            return RedirectToPage("/Courses/Manage", new { area = "Mentor", id = LessonVM.CourseId });
        }
    }
}
