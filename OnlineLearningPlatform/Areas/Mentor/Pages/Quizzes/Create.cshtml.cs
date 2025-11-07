using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using System.Reflection;
using System.Security.Claims;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Quizzes
{
    [Authorize(Roles = "Mentor")]
    public class CreateModel : PageModel
    {
        private readonly IQuizService _quizService;
        private readonly IHubContext<CRUDHub> _hub;
        private readonly ICourseService _courseService;
        private readonly IModuleService _moduleService;
        // private readonly OnlineLearningDBContext _context;

        public CreateModel(
            IQuizService quizService,
            IHubContext<CRUDHub> hub,
            ICourseService courseService,  
            IModuleService moduleService) 
        {
            _quizService = quizService;
            _hub = hub;
            _courseService = courseService; 
            _moduleService = moduleService; 
            // _context = context;
        }

        [BindProperty]
        public QuizViewModel Quiz { get; set; } = new QuizViewModel();

        // public SelectList AvailableModules { get; set; }

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

            Quiz.ModuleId = moduleId;
            Quiz.CourseId = courseId;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!ModelState.IsValid)
            {
                var course = await _courseService.GetCourseByIdAndMentorAsync(Quiz.CourseId, mentorId);
                var module = await _moduleService.GetModuleForEditAsync(Quiz.ModuleId, mentorId);

                ViewData["CourseName"] = course?.CourseName;
                ViewData["ModuleName"] = module?.ModuleName;
                ViewData["CourseId"] = Quiz.CourseId;
                ViewData["ModuleId"] = module.ModuleId;

                return Page();
            }

            await _quizService.CreateQuizAsync(Quiz);
            await _hub.Clients.All.SendAsync("loadQuizzes");
            TempData["SuccessMessage"] = "Quiz created successfully.";

            return RedirectToPage("/Courses/Manage", new { area = "Mentor", id = Quiz.CourseId });
        }
    }
}
