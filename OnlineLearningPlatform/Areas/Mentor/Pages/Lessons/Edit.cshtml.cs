using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Lessons
{
    [Authorize(Roles = "Mentor")]
    public class EditModel : PageModel
    {
        private readonly ILessonService _lessonService;
        private readonly IModuleService _moduleService;
        private readonly ICourseService _courseService;
        private readonly UserManager<User> _userManager;
        private readonly IWebHostEnvironment _env;

        public EditModel(
            ILessonService lessonService,
            IModuleService moduleService,
            ICourseService courseService,
            UserManager<User> userManager,
            IWebHostEnvironment env)
        {
            _lessonService = lessonService;
            _moduleService = moduleService;
            _courseService = courseService;
            _userManager = userManager;
            _env = env;
        }

        [BindProperty]
        public LessonInputViewModel LessonVM { get; set; } = default!;

        // bind uploaded file (optional)
        [BindProperty]
        public IFormFile? VideoFile { get; set; }

        // external URL input
        [BindProperty]
        public string? ExternalVideoUrl { get; set; }

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

            // prefill external url only if saved video is remote
            if (!string.IsNullOrWhiteSpace(LessonVM.LessonVideo) && (LessonVM.LessonVideo.StartsWith("http://") || LessonVM.LessonVideo.StartsWith("https://")))
            {
                ExternalVideoUrl = LessonVM.LessonVideo;
            }
            else
            {
                ExternalVideoUrl = null;
            }

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

            // If a video file was uploaded, validate and save it; uploaded file takes precedence over external URL.
            if (VideoFile != null && VideoFile.Length > 0)
            {
                var allowedExt = new[] { ".mp4" };
                var ext = Path.GetExtension(VideoFile.FileName).ToLowerInvariant();
                const long maxBytes = 200L * 1024 * 1024; // 200 MB

                if (!allowedExt.Contains(ext))
                {
                    ModelState.AddModelError("VideoFile", "Invalid video format. Allowed: mp4.");
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

                if (VideoFile.Length > maxBytes)
                {
                    ModelState.AddModelError("VideoFile", "Video file is too large. Max allowed size is 200 MB.");
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

                // delete existing server-stored video if any
                try
                {
                    var mentor = await _userManager.GetUserAsync(User);
                    var mentorId = await _userManager.GetUserIdAsync(mentor);
                    var existing = await _lessonService.GetLessonForEditAsync(LessonVM.LessonId, mentorId);
                    if (existing != null && !string.IsNullOrWhiteSpace(existing.LessonVideo)
                        && !(existing.LessonVideo.StartsWith("http://") || existing.LessonVideo.StartsWith("https://")))
                    {
                        var existingPath = existing.LessonVideo.TrimStart('/').Replace('/', Path.DirectorySeparatorChar);
                        var physical = Path.Combine(_env.WebRootPath, existingPath);
                        if (System.IO.File.Exists(physical))
                        {
                            System.IO.File.Delete(physical);
                        }
                    }
                }
                catch { /* ignore delete errors */ }

                var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads", "lessons", "videos");
                Directory.CreateDirectory(uploadsFolder);

                var safeFileName = $"{Guid.NewGuid()}{ext}";
                var filePath = Path.Combine(uploadsFolder, safeFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await VideoFile.CopyToAsync(stream);
                }

                // set lesson video to saved relative path and clear external
                LessonVM.LessonVideo = $"/uploads/lessons/videos/{safeFileName}";
                ExternalVideoUrl = null;
            }
            else if (!string.IsNullOrWhiteSpace(ExternalVideoUrl) && (ExternalVideoUrl.StartsWith("http://") || ExternalVideoUrl.StartsWith("https://")))
            {
                // use external link
                // if previously stored server file existed, do NOT delete it here (only delete on upload)
                LessonVM.LessonVideo = ExternalVideoUrl;
            }
            else
            {
                // preserve existing stored video path
                var mentor = await _userManager.GetUserAsync(User);
                var mentorId = await _userManager.GetUserIdAsync(mentor);
                var existing = await _lessonService.GetLessonForEditAsync(LessonVM.LessonId, mentorId);
                if (existing != null)
                {
                    LessonVM.LessonVideo = existing.LessonVideo;
                }
            }

            var mentorIdOnPost = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var success = await _lessonService.UpdateLessonAsync(LessonVM, mentorIdOnPost);

            if (!success) return NotFound();

            return RedirectToPage("/Courses/Manage", new
            {
                area = "Mentor",
                id = LessonVM.CourseId,
                moduleId = LessonVM.ModuleId
            });
        }

        public async Task<IActionResult> OnPostDeleteAsync()
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(mentorId)) return Forbid();

            var success = await _lessonService.HideLessonAsync(LessonVM.LessonId, mentorId);

            if (!success)
            {
                TempData["ErrorMessage"] = "Failed to delete lesson or lesson not found.";
                return RedirectToPage(new { id = LessonVM.LessonId });
            }

            return RedirectToPage("/Courses/Manage", new
            {
                area = "Mentor",
                id = LessonVM.CourseId,
                moduleId = LessonVM.ModuleId
            });
        }
    }
}
