using global::OnlineLearningPlatform.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Areas.Mentor.Views.Shared.Components.ViewComponents
{
    public class CourseHierarchyViewComponent : ViewComponent
    {
        private readonly ICourseService _courseService;

        public CourseHierarchyViewComponent(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task<IViewComponentResult> InvokeAsync(long courseId, long? currentModuleId, long? currentLessonId, long? currentQuizId)
        {
            var courseVM = await _courseService.GetCourseForHierarchyAsync(courseId);

            if (courseVM == null)
            {
                return Content("");
            }
            ViewBag.CurrentModuleId = currentModuleId;
            ViewBag.CurrentLessonId = currentLessonId;
            ViewBag.CurrentQuizId = currentQuizId;

            return View(courseVM);
        }
    }
}
