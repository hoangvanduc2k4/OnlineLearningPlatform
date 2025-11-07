using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.Others;
using System; // Cần cho DateTime
using System.Collections.Generic; // Cần cho List

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

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "5",
                CourseId = 1,
                Amount = 499000m, // Đã đổi sang tiền Việt
                Status = TransactionStatus.Completed, // Đã đổi
                Description = "Purchase course 1",
                DateCreated = new DateTime(2025, 3, 10)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "5",
                CourseId = 2,
                Amount = 509000m, // Đã đổi sang tiền Việt
                Status = TransactionStatus.Completed, // Đã đổi
                Description = "Purchase course 2",
                DateCreated = new DateTime(2025, 3, 11)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "5",
                CourseId = 3,
                Amount = 519000m, // Đã đổi sang tiền Việt
                Status = TransactionStatus.Completed, // Đã đổi (từ Pending)
                Description = "Purchase course 3", // Cập nhật description
                DateCreated = new DateTime(2025, 3, 12)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "5",
                CourseId = 4,
                Amount = 529000m, // Đã đổi sang tiền Việt
                Status = TransactionStatus.Completed, // Đã đổi
                Description = "Purchase course 4",
                DateCreated = new DateTime(2025, 3, 13)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "5",
                CourseId = 5,
                Amount = 539000m, // Đã đổi sang tiền Việt
                Status = TransactionStatus.Completed, // Đã đổi (từ Failed)
                Description = "Purchase course 5", // Cập nhật description
                DateCreated = new DateTime(2025, 3, 14)
            });

            list.Add(new TransactionHistory
            {
                TransactionId = id++,
                UserId = "5",
                CourseId = 6,
                Amount = 549000m, // Đã đổi sang tiền Việt
                Status = TransactionStatus.Completed, // Đã đổi
                Description = "Purchase course 6",
                DateCreated = new DateTime(2025, 3, 15)
            });

            return list;
        }
    }
}