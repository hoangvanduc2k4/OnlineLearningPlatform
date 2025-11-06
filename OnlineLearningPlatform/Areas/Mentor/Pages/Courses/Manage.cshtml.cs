using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using System.Security.Claims;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Courses
{
    public class ManageModel : PageModel
    {
        private readonly ICourseService _courseService;
        private readonly UserManager<User> _userManager;

        public ManageModel(ICourseService courseService, UserManager<User> userManager)
        {
            _courseService = courseService;
            _userManager = userManager;
        }

        public CourseDetailsViewModel CourseVM { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public long? ModuleId { get; set; } 

        [BindProperty(SupportsGet = true)]
        public long? LessonId { get; set; }

        [BindProperty(SupportsGet = true)]
        public long? QuizId { get; set; }

        public async Task<IActionResult> OnGetAsync(long id, long? moduleId, long? lessonId, long? quizId)
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            CourseVM = await _courseService.GetCourseDetailsAsync(id, null);
            if (CourseVM == null)
            {
                return NotFound();
            }
            if (CourseVM.MentorId == null || CourseVM.MentorId != mentorId)
            {
                return Forbid();
            }

            ModuleId = moduleId;
            LessonId = lessonId;
            QuizId = quizId;

            ViewData["CourseId"] = id;
            ViewData["ModuleId"] = moduleId;
            ViewData["LessonId"] = lessonId;
            ViewData["QuizId"] = quizId;
            return Page();
        }
    }
}
