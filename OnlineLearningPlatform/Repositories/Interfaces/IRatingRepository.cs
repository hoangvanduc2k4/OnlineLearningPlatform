// OnlineLearningPlatform/Repositories/Interfaces/IRatingRepository.cs
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IRatingRepository
    {
        Task<List<Ratings>> GetRatingsByCourseIdAsync(long courseId);
    }
}