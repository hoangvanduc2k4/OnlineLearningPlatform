using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ICourseEnrollmentService
    {
        Task<bool> AddCourseEnrollmmentAsync(CourseEnrollment courseEnrollment);
        Task<bool> CheckCourseEnrollment(string userId, long courseId);

    }
}
