using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class TransactionRepository : BaseRepository<TransactionHistory>, ITransactionRepository
    {
        public TransactionRepository(OnlineLearningDBContext context) : base(context)
        {
        }

        public async Task<TransactionHistory> GetTransactionByUserIdAndCourseId(string userId, long? courseId)
        {
            return await _context.TransactionHistories.FirstOrDefaultAsync(x => x.UserId == userId && x.CourseId == courseId);
        }


    }

}
