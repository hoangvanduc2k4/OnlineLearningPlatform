using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using X.PagedList;

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
        Task<List<CourseViewModel>> GetTopNewestCoursesAsync(int count = 3);

        Task<IPagedList<CourseViewModel>> GetCoursesPagedAsync(
        int pageNumber, int pageSize,
        string? searchTerm = null,
        List<string>? categories = null,
        List<long>? levelIds = null,
        string? priceRange = null,
        string? studyTimeRange = null,
        string? sortBy = null,
        string? userId = null
    );

        Task<CourseDetailsViewModel?> GetCourseDetailsAsync(long id, string? userId);

        Task<Course?> GetCourseByIdAsync(long courseId);

        Task ReviewCourseAsync(long courseId, string adminId, ReviewStatus reviewStatus, string? notes);

        Task<IPagedList<Course>> GetCoursesByStatusPagedAsync(CourseStatus status, int pageNumber, int pageSize);

        Task<Course?> GetCourseForReviewAsync(long courseId);

        Task<int> GetStudentCountsByMentorIdsAsync(string mentorId);
        Task<CourseHierarchyViewModel?> GetCourseForHierarchyAsync(long courseId);
    }

}
