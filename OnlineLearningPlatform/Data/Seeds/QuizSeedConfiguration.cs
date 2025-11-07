using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class QuizSeedConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasData(GetQuizzes().ToArray());
        }

        private static List<Quiz> GetQuizzes()
        {
            var quizzes = new List<Quiz>();
            long quizId = 1;
            var baseDate = new DateTime(2025, 1, 1);

            for (long moduleId = 1; moduleId <= 150; moduleId++)
            {
                var createdDate = baseDate.AddDays((moduleId - 1) / 3);

                quizzes.Add(new Quiz
                {
                    QuizId = quizId++,
                    ModuleId = moduleId,
                    QuizName = $"Quiz for Module {moduleId}",
                    QuizTime = 20, // 20 phút thi
                    PassScore = 70, // điểm đạt
                    CreatedAt = createdDate,
                    UpdatedAt = null,
                    DateCreated = createdDate,
                    Status = QuizStatus.Active
                });
            }

            return quizzes;
        }
    }
}