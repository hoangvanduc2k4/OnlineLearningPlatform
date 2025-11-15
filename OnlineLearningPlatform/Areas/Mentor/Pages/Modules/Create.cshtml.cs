using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Modules
{
    [Authorize(Roles = "Mentor")]
    public class CreateModel : PageModel
    {
        private readonly IModuleService _moduleService;
        private readonly UserManager<User> _userManager;
        private readonly ICourseService _courseService;
        public CreateModel(IModuleService moduleService, UserManager<User> userManager, ICourseService courseService)
        {
            _moduleService = moduleService;
            _userManager = userManager;
            _courseService = courseService;
        }

        [BindProperty]
        public ModuleInputViewModel ModuleVM { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long courseId)
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);
            if (string.IsNullOrEmpty(mentorId))
            {
                return Forbid();
            }

            var course = await _courseService.GetCourseByIdAndMentorAsync(courseId, mentorId);
            if (course == null)
            {
                return Forbid(); 
            }

            ViewData["CourseName"] = course.CourseName;
            ViewData["CourseId"] = courseId; 
            ModuleVM = new ModuleInputViewModel
            {
                CourseId = courseId
            };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);
            if (string.IsNullOrEmpty(mentorId))
            {
                return Forbid();
            }

            if (!ModelState.IsValid)
            {
                var course = await _courseService.GetCourseByIdAndMentorAsync(ModuleVM.CourseId, mentorId);
                if (course == null)
                {
                    return Forbid();
                }

                ViewData["CourseName"] = course.CourseName;
                ViewData["CourseId"] = ModuleVM.CourseId;
                return Page();
            }

            Module newModule = await _moduleService.CreateModuleAsync(ModuleVM);

            return RedirectToPage("/Courses/Manage", new
            {
                area = "Mentor",
                id = ModuleVM.CourseId,
                moduleId = newModule.ModuleId
            });
        }
    }
}
