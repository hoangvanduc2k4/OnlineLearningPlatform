using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.Others;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class MessageSeedConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasData(GetMessages().ToArray());
        }

        private static List<Message> GetMessages()
        {
            return new List<Message>
            {
                new Message
                {
                    MessageId = 1,
                    SenderId = "1", // Admin
                    ReceiverId = "3", // User
                    Content = "Chào mừng bạn đến với hệ thống học trực tuyến!",
                    CreatedAt = DateTime.Parse("2025-02-01 10:00:00"),
                    IsRead = true
                },
                new Message
                {
                    MessageId = 2,
                    SenderId = "3",
                    ReceiverId = "1",
                    Content = "Cảm ơn admin, mình rất hào hứng!",
                    CreatedAt = DateTime.Parse("2025-02-01 10:05:00"),
                    IsRead = true
                },
                new Message
                {
                    MessageId = 3,
                    SenderId = "4",
                    ReceiverId = "5",
                    Content = "Bạn có muốn tham gia nhóm học chung không?",
                    CreatedAt = DateTime.Parse("2025-02-02 15:20:00"),
                    IsRead = false
                },
                new Message
                {
                    MessageId = 4,
                    SenderId = "5",
                    ReceiverId = "4",
                    Content = "Ok, mình rất quan tâm.",
                    CreatedAt = DateTime.Parse("2025-02-02 15:25:00"),
                    IsRead = false
                },
                new Message
                {
                    MessageId = 5,
                    SenderId = "2", // Admin reviewer
                    ReceiverId = "6", // Applicant
                    Content = "Chúng tôi đã nhận được đơn ứng tuyển mentor của bạn.",
                    CreatedAt = DateTime.Parse("2025-02-03 09:00:00"),
                    IsRead = true
                }
            };
        }
    }
}
