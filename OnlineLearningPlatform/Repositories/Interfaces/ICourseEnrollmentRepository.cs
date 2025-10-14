using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface ICourseEnrollmentRepository : IBaseRepository<CourseEnrollment>
    {
        Task<bool> CheckUserPurchaseCourseAsync(string userId, long courseId);

    }
}
