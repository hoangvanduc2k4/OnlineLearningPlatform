// OnlineLearningPlatform/Repositories/Interfaces/IRatingRepository.cs
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IRatingRepository
    {
        Task<List<Ratings>> GetRatingsByCourseIdAsync(long courseId);
    }
}