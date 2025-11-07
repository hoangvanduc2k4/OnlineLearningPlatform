using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using X.PagedList;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ICourseEnrollmentService
    {
        Task<bool> AddCourseEnrollmmentAsync(CourseEnrollment courseEnrollment);
        Task<bool> CheckCourseEnrollment(string userId, long courseId);
        Task<int> GetStudentCountByMentorIdAsync(string instructorId);

        Task<IPagedList<CourseViewModel>> GetEnrolledCoursesPagedAsync(string userId, int pageNumber, int pageSize, string? searchTerm);
    }
}
