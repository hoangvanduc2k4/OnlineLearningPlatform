using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using X.PagedList;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        IQueryable<Course> GetCoursesQuery();

        Task<IEnumerable<Course>> GetAllByMentorIdAsync(string mentorId);
        Task<Course?> GetByIdAndMentorIdAsync(long courseId, string mentorId);
        Task<Course?> GetCourseForEditAsync(long courseId, string mentorId);
        Task<Course?> GetCourseForReviewAsync(long courseId);
        Task<Course?> GetByIdWithDetailsAsync(long id);
        Task<IPagedList<Course>> GetCoursesByStatusPagedAsync(CourseStatus status, int pageNumber, int pageSize);
        Task<int> GetCourseCountsByMentorIdsAsync(string mentorId);
    }
}