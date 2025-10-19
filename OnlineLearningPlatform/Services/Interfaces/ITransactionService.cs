using OnlineLearningPlatform.Models.Entities.Others;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ITransactionService
    {
        public Task<bool> AddTransactionAsync(TransactionHistory transaction);
        public Task<bool> UpdateTransactionAsync(TransactionHistory transaction);
        public Task<TransactionHistory> GetTransactionById(long? transactionId);

    }
}
