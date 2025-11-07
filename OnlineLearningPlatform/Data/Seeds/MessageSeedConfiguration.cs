using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.Others;
using System;
using System.Collections.Generic;

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
                    SenderId = "1",
                    ReceiverId = "3",
                    Content = "Welcome to the online learning system!",
                    CreatedAt = DateTime.Parse("2025-02-01 10:00:00"),
                    IsRead = true
                },
                new Message
                {
                    MessageId = 2,
                    SenderId = "3",
                    ReceiverId = "1",
                    Content = "Thank you admin, I'm very excited!",
                    CreatedAt = DateTime.Parse("2025-02-01 10:05:00"),
                    IsRead = true
                },
                new Message
                {
                    MessageId = 3,
                    SenderId = "4",
                    ReceiverId = "5",
                    Content = "Do you want to join the study group?",
                    CreatedAt = DateTime.Parse("2025-02-02 15:20:00"),
                    IsRead = false
                },
                new Message
                {
                    MessageId = 4,
                    SenderId = "5",
                    ReceiverId = "4",
                    Content = "Ok, I'm very interested.",
                    CreatedAt = DateTime.Parse("2025-02-02 15:25:00"),
                    IsRead = false
                },
                new Message
                {
                    MessageId = 5,
                    SenderId = "2",
                    ReceiverId = "6",
                    Content = "We have received your mentor application.",
                    CreatedAt = DateTime.Parse("2025-02-03 09:00:00"),
                    IsRead = true
                }
            };
        }
    }
}