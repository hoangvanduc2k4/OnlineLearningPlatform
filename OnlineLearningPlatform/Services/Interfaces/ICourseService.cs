using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetCoursesForMentorAsync(string mentorId);
        Task<Course?> GetCourseByIdAndMentorAsync(long courseId, string mentorId);
        Task<Course> CreateCourseAsync(Course course, string mentorId);
        Task<bool> UpdateCourseAsync(Course course, string mentorId);
        Task<bool> DeleteCourseAsync(long courseId, string mentorId);
    }
}
