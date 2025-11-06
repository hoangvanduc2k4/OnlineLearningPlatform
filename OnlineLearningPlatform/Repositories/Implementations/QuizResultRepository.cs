using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class QuizResultRepository : BaseRepository<QuizResult>, IQuizResultRepository
    {
        public QuizResultRepository(OnlineLearningDBContext context) : base(context) { }

        public async Task<List<QuizResult>> GetResultsByUserAndQuizAsync(string userId, long quizId, int take = 10)
        {
            return await _dbSet
                .Where(q => q.UserId == userId && q.QuizId == quizId)
                .OrderByDescending(q => q.CreatedAt)
                .Take(take)
                .ToListAsync();
        }

        public async Task<List<QuizResult>> GetResultsByQuizAsync(long quizId)
        {
            return await _dbSet
                .Where(q => q.QuizId == quizId)
                .OrderByDescending(q => q.CreatedAt)
                .ToListAsync();
        }
    }
}
