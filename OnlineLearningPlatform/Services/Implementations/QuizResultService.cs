using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class QuizResultService : IQuizResultService
    {
        private readonly IQuizResultRepository _quizResultRepository;
        public QuizResultService(IQuizResultRepository quizResultRepository)
        {
            _quizResultRepository = quizResultRepository;
        }

        public async Task<List<QuizResult>> GetResultsByUserAndQuizAsync(string userId, long quizId, int take = 10)
        {
            return await _quizResultRepository.GetResultsByUserAndQuizAsync(userId, quizId, take);
        }

        public async Task<List<QuizResult>> GetResultsByQuizAsync(long quizId)
        {
            return await _quizResultRepository.GetResultsByQuizAsync(quizId);
        }

        public async Task AddQuizResultAsync(QuizResult result)
        {
            await _quizResultRepository.AddAsync(result);
        }

        public async Task DeleteQuizResultAsync(QuizResult quizResult)
        {
            await _quizResultRepository.DeleteAsync(quizResult);
        }
    }
}
