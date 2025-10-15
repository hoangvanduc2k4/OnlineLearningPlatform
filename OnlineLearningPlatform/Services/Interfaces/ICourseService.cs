using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetCoursesForMentorAsync(string mentorId);
        Task<Course?> GetCourseByIdAndMentorAsync(long courseId, string mentorId);
        Task<Course?> GetCourseForEditAsync(long courseId, string mentorId);
        Task<Course> CreateCourseAsync(Course course, string mentorId, List<long> categoryIds, string? coverImageUrl);
        Task<bool> UpdateCourseAsync(Course courseToUpdate, List<long> categoryIds, string? newCoverImageUrl, CourseStatus newStatus, string? mentorId);
        Task<bool> DeleteCourseAsync(long courseId, string mentorId);
    }
}
