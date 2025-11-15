using OnlineLearningPlatform.Models.Entities.Others;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IAdminReviewCourseRepository : IBaseRepository<AdminReviewCourse>
    {
        IQueryable<AdminReviewCourse> GetReviewsQuery();
    }
}
