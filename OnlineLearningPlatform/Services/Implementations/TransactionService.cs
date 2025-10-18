using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepo;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepo = transactionRepository;
        }
        public async Task<bool> AddTransactionAsync(TransactionHistory transaction)
        {
            var trs = await _transactionRepo.AddAsync(transaction);
            return trs != null;
        }
        public async Task<bool> UpdateTransactionAsync(TransactionHistory transaction)
        {
            bool trs = true;
            if (transaction != null)
            {
                await _transactionRepo.UpdateAsync(transaction);
            }
            return trs;
        }

        public Task<TransactionHistory> GetTransactionById(long? transactionId)
        {
            return _transactionRepo.GetTransactionById(transactionId);
        }


    }
}
