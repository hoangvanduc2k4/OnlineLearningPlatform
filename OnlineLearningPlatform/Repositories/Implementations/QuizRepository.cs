using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class QuizRepository : BaseRepository<Quiz>, IQuizRepository
    {
        public QuizRepository(OnlineLearningDBContext context) : base(context)
        {
        }
        public async Task<Quiz?> GetByIdWithCourseAsync(long id)
        {
            return await _dbSet
                .Include(q => q.Module)
                .ThenInclude(m => m.Course)
                .FirstOrDefaultAsync(q => q.QuizId == id);
        }
        public async Task<IEnumerable<Quiz>> GetAllWithModuleAndCourseAsync()
        {
            return await _context.Quizzes
                .Include(q => q.Module)
                .ThenInclude(m => m.Course)
                .ToListAsync();
        }

    }
}
