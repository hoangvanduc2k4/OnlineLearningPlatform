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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Lessons
{
    [Authorize(Roles = "Mentor")]
    [RequestSizeLimit(200_000_000)] // 200 MB

    public class CreateModel : PageModel
    {
        private readonly ILessonService _lessonService;
        private readonly IModuleService _module_service;
        private readonly ICourseService _courseService;
        private readonly UserManager<User> _userManager;
        private readonly IWebHostEnvironment _env;

        public CreateModel(
            ILessonService lessonService,
            IModuleService moduleService,
            ICourseService courseService,
            UserManager<User> userManager,
            IWebHostEnvironment env)
        {
            _lessonService = lessonService;
            _module_service = moduleService;
            _courseService = courseService;
            _userManager = userManager;
            _env = env;
        }

        [BindProperty]
        public LessonInputViewModel LessonVM { get; set; } = default!;

        // bind uploaded file (optional)
        [BindProperty]
        public IFormFile? VideoFile { get; set; }

        public async Task<IActionResult> OnGetAsync(long moduleId, long courseId)
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(mentorId)) return Forbid();
            if (courseId == 0 || moduleId == 0) return NotFound();

            var course = await _courseService.GetCourseByIdAndMentorAsync(courseId, mentorId);
            var module = await _module_service.GetModuleForEditAsync(moduleId, mentorId);

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
                var module = await _module_service.GetModuleForEditAsync(LessonVM.ModuleId, mentorId);

                ViewData["CourseName"] = course?.CourseName;
                ViewData["ModuleName"] = module?.ModuleName;
                ViewData["CourseId"] = LessonVM.CourseId;
                ViewData["ModuleId"] = LessonVM.ModuleId;

                return Page();
            }

            // If a video file was uploaded, validate and save it; uploaded file takes precedence over external URL.
            if (VideoFile != null && VideoFile.Length > 0)
            {
                var allowedExt = new[] { ".mp4"};
                var ext = Path.GetExtension(VideoFile.FileName).ToLowerInvariant();
                const long maxBytes = 200L * 1024 * 1024; // 200 MB

                if (!allowedExt.Contains(ext))
                {
                    ModelState.AddModelError("VideoFile", "Invalid video format. Allowed: mp4, mov, webm, ogg.");
                    var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var course = await _courseService.GetCourseByIdAndMentorAsync(LessonVM.CourseId, mentorId);
                    var module = await _module_service.GetModuleForEditAsync(LessonVM.ModuleId, mentorId);
                    ViewData["CourseName"] = course?.CourseName;
                    ViewData["ModuleName"] = module?.ModuleName;
                    ViewData["CourseId"] = LessonVM.CourseId;
                    ViewData["ModuleId"] = LessonVM.ModuleId;
                    return Page();
                }

                if (VideoFile.Length > maxBytes)
                {
                    ModelState.AddModelError("VideoFile", "Video file is too large. Max allowed size is 200 MB.");
                    var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var course = await _courseService.GetCourseByIdAndMentorAsync(LessonVM.CourseId, mentorId);
                    var module = await _module_service.GetModuleForEditAsync(LessonVM.ModuleId, mentorId);
                    ViewData["CourseName"] = course?.CourseName;
                    ViewData["ModuleName"] = module?.ModuleName;
                    ViewData["CourseId"] = LessonVM.CourseId;
                    ViewData["ModuleId"] = LessonVM.ModuleId;
                    return Page();
                }

                var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads", "lessons", "videos");
                Directory.CreateDirectory(uploadsFolder);

                var safeFileName = $"{Guid.NewGuid()}{ext}";
                var filePath = Path.Combine(uploadsFolder, safeFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await VideoFile.CopyToAsync(stream);
                }

                // set lesson video to saved relative path
                LessonVM.LessonVideo = $"/uploads/lessons/videos/{safeFileName}";
            }

            await _lessonService.CreateLessonAsync(LessonVM);

            return RedirectToPage("/Courses/Manage", new
            {
                area = "Mentor",
                id = LessonVM.CourseId,
                moduleId = LessonVM.ModuleId
            });
        }
    }
}
