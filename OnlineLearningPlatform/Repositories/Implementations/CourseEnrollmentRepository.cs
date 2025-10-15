using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class CourseEnrollmentRepository : BaseRepository<CourseEnrollment>, ICourseEnrollmentRepository
    {
        public CourseEnrollmentRepository(OnlineLearningDBContext context) : base(context)
        {
        }

        public async Task<bool> CheckUserPurchaseCourseAsync(string userId, long courseId)
        {
            if (string.IsNullOrEmpty(userId)) return false;
            var transactionHistory = await _context.CourseEnrollments
                                    .FirstOrDefaultAsync(t => t.UserId == userId
                                                    && t.CourseId == courseId);
            return transactionHistory != null;
        }

    }
}
