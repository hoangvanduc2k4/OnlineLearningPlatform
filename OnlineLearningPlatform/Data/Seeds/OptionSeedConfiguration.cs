using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class OptionSeedConfiguration : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {
            builder.HasData(GetOptions().ToArray());
        }

        private static List<Option> GetOptions()
        {
            var options = new List<Option>();
            long optionId = 1;

            // Tổng số câu hỏi = 12 quiz * 5 câu hỏi = 60
            for (long questionId = 1; questionId <= 60; questionId++)
            {
                for (int o = 1; o <= 4; o++)
                {
                    options.Add(new Option
                    {
                        OptionId = optionId++,
                        QuestionId = questionId,
                        OptionText = $"Option {o} for Question {questionId}",
                        IsCorrect = (o == 1), // chỉ Option 1 là đúng
                        Status = CommonStatus.Showed,
                        DateCreated = new DateTime(2025, 1, 1)
                    });
                }
            }

            return options;
        }
    }
}
