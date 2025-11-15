using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class AdminReviewCourseRepository : BaseRepository<AdminReviewCourse>, IAdminReviewCourseRepository
    {
        public AdminReviewCourseRepository(OnlineLearningDBContext context) : base(context) { }

        public IQueryable<AdminReviewCourse> GetReviewsQuery()
        {
            return _context.AdminReviewCourses.AsNoTracking();
        }
    }
}