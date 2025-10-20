using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.Others; // Đảm bảo namespace này đúng
using System;
using System.Collections.Generic;

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
            var transactionsList = new List<TransactionHistory>();
            var random = new Random();
            long currentTransactionId = 1;
            var transactionDate = new DateTime(2025, 3, 1);

            // ===== CÁC THAM SỐ CẤU HÌNH =====
            var userIds = new List<string> { "5", "6", "7" };
            const int totalCourses = 55;
            const int transactionsPerUser = 10;

            // ===== LOGIC TẠO DỮ LIỆU TỰ ĐỘNG =====
            foreach (var userId in userIds)
            {
                // Sử dụng HashSet để đảm bảo mỗi user không mua trùng một khóa học
                var purchasedCourseIds = new HashSet<int>();

                for (int i = 0; i < transactionsPerUser; i++)
                {
                    // Chọn một CourseId ngẫu nhiên và đảm bảo chưa được mua bởi user này
                    int courseId;
                    do
                    {
                        courseId = random.Next(1, totalCourses + 1);
                    } while (purchasedCourseIds.Contains(courseId));
                    purchasedCourseIds.Add(courseId);

                    // Tạo một giá tiền ngẫu nhiên cho khóa học
                    decimal amount = Math.Round((decimal)(20.0 + random.NextDouble() * 80.0), 2);

                    transactionsList.Add(new TransactionHistory
                    {
                        TransactionId = currentTransactionId++,
                        UserId = userId,
                        CourseId = courseId,
                        Amount = amount,
                        Status = TransactionStatus.Completed, // Luôn luôn thành công
                        Description = $"Purchase of course {courseId}", // Mô tả tự động
                        DateCreated = transactionDate.AddDays(currentTransactionId) // Ngày tháng tăng dần
                    });
                }
            }

            return transactionsList;
        }
    }
}