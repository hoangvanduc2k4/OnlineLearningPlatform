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
            var getTransaction = await _transactionRepo.GetTransactionByUserIdAndCourseId(transaction.UserId, transaction.CourseId);

            if (getTransaction != null)
            {
                return false;
            }
            var trs = await _transactionRepo.AddAsync(transaction);
            return trs != null;
        }

    }
}
