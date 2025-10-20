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
            var messages = new List<Message>(); // Bắt đầu với một danh sách trống
            var random = new Random();
            long currentMessageId = 1; // ID bắt đầu từ 1

            var adminMentorIds = new List<string> { "1", "2", "3", "4" };
            const int startReceiverId = 5;
            const int endReceiverId = 55;

            var messageTemplates = new List<string>
            {
                "Hello! We noticed you're making great progress in your course. Keep up the excellent work!",
                "Just a friendly reminder that a new module has been unlocked in your course.",
                "Do you have any questions or need assistance with your current lesson? We're here to help.",
                "We have a new course on Advanced C# that you might be interested in. Check it out!",
                "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.",
                "Welcome aboard! We're thrilled to have you as part of our learning community.",
                "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!",
                "Did you know you can download course resources from the 'Materials' tab? Hope this helps!"
            };

            // Vòng lặp tạo 50 tin nhắn
            for (int i = 0; i < 50; i++)
            {
                // Chọn ngẫu nhiên người gửi từ danh sách Admin/Mentor
                var senderId = adminMentorIds[random.Next(adminMentorIds.Count)];

                // Chọn ngẫu nhiên người nhận từ 5 đến 55
                var receiverId = random.Next(startReceiverId, endReceiverId + 1).ToString();

                // Chọn ngẫu nhiên nội dung tin nhắn
                var content = messageTemplates[random.Next(messageTemplates.Count)];

                // Tạo ngày tháng tăng dần
                var createdAt = new DateTime(2025, 2, 4).AddHours(i * 5);

                messages.Add(new Message
                {
                    MessageId = currentMessageId++,
                    SenderId = senderId,
                    ReceiverId = receiverId,
                    Content = content,
                    CreatedAt = createdAt,
                    IsRead = random.Next(0, 2) == 1 // Trạng thái đọc ngẫu nhiên (true/false)
                });
            }

            return messages;
        }
    }
}