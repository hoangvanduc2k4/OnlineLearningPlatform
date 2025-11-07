using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic; // Phải có using này
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class FAQSeedConfiguration : IEntityTypeConfiguration<FAQ>
    {
        public void Configure(EntityTypeBuilder<FAQ> builder)
        {
            builder.HasData(GetFaqs().ToArray());
        }

        private static List<FAQ> GetFaqs()
        {
            var faqs = new List<FAQ>();
            var baseDate = new DateTime(2025, 1, 1);

            var topics = new[] { "payment", "account access", "course content", "certificates", "refunds", "support", "mobile app", "instructor" };

            for (long i = 1; i <= 50; i++)
            {
                var topic = topics[(int)((i - 1) % topics.Length)];
                var createdDate = baseDate.AddDays(i - 1);

                faqs.Add(new FAQ
                {
                    FaqId = i,
                    Question = $"Sample Question {i}: What is the policy for {topic}?",
                    Answer = $"This is the detailed sample answer for question {i} regarding {topic}. " +
                             "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CreatedAt = createdDate,
                    UpdatedAt = createdDate,
                    CommonStatus = CommonStatus.Showed
                });
            }

            return faqs;
        }
    }
}