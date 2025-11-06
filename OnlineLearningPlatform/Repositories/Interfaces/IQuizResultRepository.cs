using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IQuizResultRepository : IBaseRepository<QuizResult>
    {
        Task<List<QuizResult>> GetResultsByUserAndQuizAsync(string userId, long quizId, int take = 10);
        Task<List<QuizResult>> GetResultsByQuizAsync(long quizId);
    }
}
