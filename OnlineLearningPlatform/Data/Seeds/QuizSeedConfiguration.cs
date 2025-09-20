using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.CoursePart;

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

            // Tạo quiz cho 12 module đầu tiên
            for (long moduleId = 1; moduleId <= 12; moduleId++)
            {
                quizzes.Add(new Quiz
                {
                    QuizId = quizId++,
                    ModuleId = moduleId,
                    QuizName = $"Quiz for Module {moduleId}",
                    QuizTime = 20, // 20 phút thi
                    PassScore = 70, // điểm đạt
                    CreatedAt = new DateTime(2025, 1, 1),
                    UpdatedAt = null,
                    DateCreated = new DateTime(2025, 1, 1)
                });
            }

            return quizzes;
        }
    }
}
