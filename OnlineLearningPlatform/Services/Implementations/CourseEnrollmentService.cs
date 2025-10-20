using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class CourseEnrollmentService : ICourseEnrollmentService
    {
        private readonly ICourseEnrollmentRepository _courseEnrollmentRepository;
        public CourseEnrollmentService(ICourseEnrollmentRepository courseEnrollmentRepository)
        {
            _courseEnrollmentRepository = courseEnrollmentRepository;
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
    }
}
