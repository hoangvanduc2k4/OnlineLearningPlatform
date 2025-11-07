using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;

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
            var baseDate = new DateTime(2025, 1, 1);

            for (long questionId = 1; questionId <= 750; questionId++)
            {
                long quizId = ((questionId - 1) / 5) + 1;
                var createdDate = baseDate.AddDays((quizId - 1) / 3);

                for (int o = 1; o <= 4; o++)
                {
                    options.Add(new Option
                    {
                        OptionId = optionId++,
                        QuestionId = questionId,
                        OptionText = $"Option {o} for Question {questionId}",
                        IsCorrect = (o == 1),
                        Status = CommonStatus.Showed,
                        DateCreated = createdDate
                    });
                }
            }

            return options;
        }
    }
}