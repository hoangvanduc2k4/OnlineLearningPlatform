using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IQuizResultService
    {
        Task<List<QuizResult>> GetResultsByUserAndQuizAsync(string userId, long quizId, int take = 10);
        Task<List<QuizResult>> GetResultsByQuizAsync(long quizId);
        Task AddQuizResultAsync(QuizResult result);

        Task DeleteQuizResultAsync(QuizResult quizResultId);
    }
}
