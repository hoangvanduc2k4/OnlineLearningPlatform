using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Enums;
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

        public async Task<TransactionHistory> GetTransactionById(long? transactionId)
        {
            return await _context.TransactionHistories.Include(x => x.User).Include(x => x.Course).FirstOrDefaultAsync(x => x.TransactionId == transactionId);
        }


        public async Task<List<TransactionHistory>> GetSuccessfulTransactionsByDateRangeAsync(DateTime? startDate, DateTime? endDate)
        {
            IQueryable<TransactionHistory> query = _context.TransactionHistories;

            query = query.Where(t => t.Status == TransactionStatus.Completed);

            if (startDate.HasValue)
            {
                query = query.Where(t => t.DateCreated.Date >= startDate.Value.Date);
            }
            if (endDate.HasValue)
            {
                query = query.Where(t => t.DateCreated.Date <= endDate.Value.Date);
            }

            var result = await query
                .Include(t => t.Course)
                .OrderByDescending(t => t.DateCreated)
                .ToListAsync();

            return result;
        }

    }

}
