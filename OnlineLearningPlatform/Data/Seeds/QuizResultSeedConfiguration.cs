using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class QuizResultSeedConfiguration : IEntityTypeConfiguration<QuizResult>
    {
        public void Configure(EntityTypeBuilder<QuizResult> builder)
        {
            builder.HasData(GetQuizResults().ToArray());
        }

        private static List<QuizResult> GetQuizResults()
        {
            var results = new List<QuizResult>();
            long quizResultId = 1;

            // giả sử mỗi quiz có 5 câu hỏi (theo seed Question)
            int totalQuestions = 5;

            // mỗi quiz có kết quả của 2 user: user 3 và user 4
            for (long quizId = 1; quizId <= 12; quizId++)
            {
                results.Add(new QuizResult
                {
                    QuizResultId = quizResultId++,
                    UserId = "3",
                    QuizId = quizId,
                    TotalQuestions = totalQuestions,
                    CorrectAnswers = 4,
                    Score = 80.00m,
                    StartTime = new DateTime(2025, 3, 1, 10, 0, 0),
                    EndTime = new DateTime(2025, 3, 1, 10, 15, 0),
                    CreatedAt = new DateTime(2025, 3, 1, 10, 15, 0)
                });

                results.Add(new QuizResult
                {
                    QuizResultId = quizResultId++,
                    UserId = "4",
                    QuizId = quizId,
                    TotalQuestions = totalQuestions,
                    CorrectAnswers = 3,
                    Score = 60.00m,
                    StartTime = new DateTime(2025, 3, 2, 9, 30, 0),
                    EndTime = new DateTime(2025, 3, 2, 9, 45, 0),
                    CreatedAt = new DateTime(2025, 3, 2, 9, 45, 0)
                });
            }

            return results;
        }
    }
}
