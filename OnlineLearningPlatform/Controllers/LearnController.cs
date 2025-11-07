using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Controllers
{
    public class LearnController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ILessonService _lessonService;
        private readonly UserManager<OnlineLearningPlatform.Models.Entities.UserPart.User> _userManager;

        public LearnController(ICourseService courseService, UserManager<OnlineLearningPlatform.Models.Entities.UserPart.User> userManager, ILessonService lessonService)
        {
            _courseService = courseService;
            _userManager = userManager;
            _lessonService = lessonService;
        }

        // GET: /Learn/Course/5
        public async Task<IActionResult> Course(int id, long? lessonId = null)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await _courseService.GetCourseDetailsToLearnAsync(id, userId);
            if (model == null || !model.IsEnrolled) return NotFound();

            // Chọn lesson đầu tiên nếu chưa có lessonId
            var firstLesson = model.Modules.SelectMany(m => m.Lessons).OrderBy(l => l.LessonNumber).FirstOrDefault();
            var selectedLesson = lessonId != null
                ? model.Modules.SelectMany(m => m.Lessons).FirstOrDefault(l => l.LessonId == lessonId)
                : firstLesson;
            ViewBag.SelectedLesson = selectedLesson;
            return View(model);
        }

        // GET: /Learn/GetLesson/123
        public async Task<IActionResult> GetLesson(long id)
        {
            var lesson = await _lessonService.GetLessonViewModelByIdAsync(id);
            lesson = await _lessonService.GetLessonViewModelByIdAsync(id);
            if (lesson == null) return NotFound();
            return PartialView("_LessonContent", lesson);
        }

    }
}
