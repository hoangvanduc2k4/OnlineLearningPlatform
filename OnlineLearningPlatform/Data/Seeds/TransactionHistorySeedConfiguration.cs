using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.Others;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class TransactionHistorySeedConfiguration : IEntityTypeConfiguration<TransactionHistory>
    {
        public void Configure(EntityTypeBuilder<TransactionHistory> builder)
        {
            builder.HasData(GetTransactions().ToArray());
        }

        private static List<TransactionHistory> GetTransactions()
        {
            var list = new List<TransactionHistory>();
            long id = 1;

            // 6 giao dịch mẫu cho userId = 3
            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "3",
                CourseId = 1,
                Amount = 19.99m,
                Status = TransactionStatus.Completed,
                Description = "Purchase course 1",
                DateCreated = new DateTime(2025, 3, 10)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "3",
                CourseId = 2,
                Amount = 29.99m,
                Status = TransactionStatus.Completed,
                Description = "Purchase course 2",
                DateCreated = new DateTime(2025, 3, 11)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "3",
                CourseId = 3,
                Amount = 24.99m,
                Status = TransactionStatus.Pending,
                Description = "Pending payment for course 3",
                DateCreated = new DateTime(2025, 3, 12)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "3",
                CourseId = 4,
                Amount = 34.99m,
                Status = TransactionStatus.Completed,
                Description = "Purchase course 4",
                DateCreated = new DateTime(2025, 3, 13)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "3",
                CourseId = 5,
                Amount = 39.99m,
                Status = TransactionStatus.Failed,
                Description = "Failed transaction for course 5",
                DateCreated = new DateTime(2025, 3, 14)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "3",
                CourseId = 6,
                Amount = 44.99m,
                Status = TransactionStatus.Completed,
                Description = "Purchase course 6",
                DateCreated = new DateTime(2025, 3, 15)
            });

            return list;
        }
    }
}
