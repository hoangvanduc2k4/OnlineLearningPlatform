using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;
using X.PagedList.Extensions;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class CourseEnrollmentService : ICourseEnrollmentService
    {
        private readonly ICourseEnrollmentRepository _courseEnrollmentRepository;
        private readonly ICourseRepository _courseRepository;
        public CourseEnrollmentService(ICourseEnrollmentRepository courseEnrollmentRepository, ICourseRepository courseRepository)
        {
            _courseEnrollmentRepository = courseEnrollmentRepository;
            _courseRepository = courseRepository;
        }
        public async Task<bool> AddCourseEnrollmmentAsync(CourseEnrollment courseEnrollment)
        {
            var enrollment = await _courseEnrollmentRepository.AddAsync(courseEnrollment);
            return courseEnrollment != null;
        }

        public async Task<bool> CheckCourseEnrollment(string userId, long courseId)
        {
            return await _courseEnrollmentRepository.CheckUserPurchaseCourseAsync(userId, courseId);
        }

        public async Task<int> GetStudentCountByMentorIdAsync(string mentorId)
        {
            return await _courseEnrollmentRepository.GetStudentCountByMentorIdAsync(mentorId);
        }

        public async Task<IPagedList<CourseViewModel>> GetEnrolledCoursesPagedAsync(string userId, int pageNumber, int pageSize, string? searchTerm = null)
        {
            var enrollments = await _courseEnrollmentRepository.GetAllAsync();
            var enrolledCourseIds = enrollments.Where(e => e.UserId == userId).Select(e => e.CourseId).ToList();
            if (!enrolledCourseIds.Any())
                return new StaticPagedList<CourseViewModel>(new List<CourseViewModel>(), pageNumber, pageSize, 0);

            var query = _courseRepository.GetCoursesQuery()
                .Where(c => enrolledCourseIds.Contains(c.CourseId) && c.Status == CourseStatus.Approved);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lower = searchTerm.Trim().ToLower();
                query = query.Where(c => c.CourseName.ToLower().Contains(lower));
            }

            var courses = await query.ToListAsync();

            var vmList = courses.Select(c => new CourseViewModel
            {
                CourseId = c.CourseId,
                CourseName = c.CourseName,
                Description = c.Description,
                Price = c.Price,
                Discount = c.Discount,
                ImageUrl = c.CourseImageUrls.FirstOrDefault()?.Url,
                StudyTime = c.StudyTime,
                MentorId = c.Creator,
                MentorName = c.CreatorUser?.FullName,
                MentorAvatarUrl = c.CreatorUser?.AvatarUrl,
                IsEnrolled = true,
                LevelName = c.Level?.LevelName,
                Status = c.Status.ToString(),
                CategoryNames = c.CourseCategories.Select(cc => cc.Category.CategoryName).ToList()
            }).ToList();

            var paged = vmList.ToPagedList(pageNumber, pageSize);
            return paged;
        }
    }
}
