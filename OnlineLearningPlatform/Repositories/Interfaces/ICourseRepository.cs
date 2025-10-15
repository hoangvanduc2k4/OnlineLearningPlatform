using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using X.PagedList;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        Task<IEnumerable<Course>> GetAllByMentorIdAsync(string mentorId);
        Task<Course?> GetByIdAndMentorIdAsync(long courseId, string mentorId);
        Task<Course?> GetCourseForEditAsync(long courseId, string mentorId);
        Task<IPagedList<Course>> GetCoursesPagedAsync(
            int pageNumber,
            int pageSize,
            string? searchTerm = null,
            CourseStatus? status = null,
            List<string>? categories = null,
            List<long>? levelIds = null,
            string? priceRange = null,
            string? studyTimeRange = null,
            string? sortBy = null
        );

        Task<Course?> GetByIdWithDetailsAsync(long id);
    }
}
