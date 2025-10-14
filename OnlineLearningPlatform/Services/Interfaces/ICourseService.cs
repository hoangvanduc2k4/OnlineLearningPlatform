using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using X.PagedList;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ICourseService
    {
        Task<IPagedList<CourseViewModel>> GetCoursesPagedAsync(
            int pageNumber, int pageSize,
            string? searchTerm = null,
            List<string>? categories = null,
            List<long>? levelIds = null,
            string? priceRange = null,
            string? studyTimeRange = null,
            string? sortBy = null
        );

        Task<CourseDetailsViewModel?> GetCourseDetailsAsync(long id);
        Task<Course?> GetCourseByIdAsync(long courseId);


    }

}
