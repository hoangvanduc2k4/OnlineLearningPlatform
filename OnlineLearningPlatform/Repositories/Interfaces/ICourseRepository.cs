using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        Task<IEnumerable<Course>> GetAllByMentorIdAsync(string mentorId);
        Task<Course?> GetByIdAndMentorIdAsync(long courseId, string mentorId);
    }
}
