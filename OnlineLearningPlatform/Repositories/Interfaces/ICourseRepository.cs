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
        IQueryable<Course> GetAllCoursesQueryable();

        Task<Course?> GetByIdWithDetailsAsync(long id);
    }
}
