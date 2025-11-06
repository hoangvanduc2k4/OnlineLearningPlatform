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

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Modules
{
    [Authorize(Roles = "Mentor")]
    public class EditModel : PageModel
    {
        private readonly IModuleService _moduleService;
        private readonly UserManager<User> _userManager;
        private readonly ICourseService _courseService; 

        public EditModel(IModuleService moduleService, UserManager<User> userManager, ICourseService courseService)
        {
            _moduleService = moduleService;
            _userManager = userManager;
            _courseService = courseService;
        }

        [BindProperty]
        public ModuleInputViewModel ModuleVM { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long id)
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);
            if (string.IsNullOrEmpty(mentorId)) return Forbid();

            var moduleViewModel = await _moduleService.GetModuleForEditAsync(id, mentorId);
            if (moduleViewModel == null) return NotFound();

            ModuleVM = moduleViewModel;

            var course = await _courseService.GetCourseByIdAndMentorAsync(ModuleVM.CourseId, mentorId);
            if (course == null) return Forbid();

            ViewData["CourseName"] = course.CourseName;
            ViewData["CourseId"] = ModuleVM.CourseId;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);
            if (string.IsNullOrEmpty(mentorId)) return Forbid();

            if (!ModelState.IsValid)
            {
                var course = await _courseService.GetCourseByIdAndMentorAsync(ModuleVM.CourseId, mentorId);
                if (course == null) return Forbid();

                ViewData["CourseName"] = course.CourseName;
                ViewData["CourseId"] = ModuleVM.CourseId;
                return Page();
            }

            var success = await _moduleService.UpdateModuleAsync(ModuleVM, mentorId);
            if (!success) return NotFound();

            return RedirectToPage("./Index");
        }
    }
}
