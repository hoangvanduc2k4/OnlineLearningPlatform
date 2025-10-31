using OnlineLearningPlatform.Models.Entities.Others;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface ITransactionRepository : IBaseRepository<TransactionHistory>
    {
        Task<TransactionHistory> GetTransactionByUserIdAndCourseId(string userId, long? courseId);
        Task<TransactionHistory> GetTransactionById(long? transactionId);
        Task<List<TransactionHistory>> GetSuccessfulTransactionsByDateRangeAsync(DateTime? startDate, DateTime? endDate);
    }
}
