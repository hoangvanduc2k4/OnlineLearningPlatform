using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System;
using System.Collections.Generic;

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
            int totalQuestions = 5;

            var baseDateUser5 = new DateTime(2025, 3, 1, 10, 0, 0);
            var baseDateUser6 = new DateTime(2025, 3, 2, 9, 30, 0);

            for (long quizId = 1; quizId <= 150; quizId++)
            {
                var user5StartTime = baseDateUser5.AddDays(quizId - 1);
                var user5EndTime = user5StartTime.AddMinutes(15); // Giả sử làm trong 15 phút

                var user6StartTime = baseDateUser6.AddDays(quizId - 1);
                var user6EndTime = user6StartTime.AddMinutes(15);

                results.Add(new QuizResult
                {
                    QuizResultId = quizResultId++,
                    UserId = "5",
                    QuizId = quizId,
                    TotalQuestions = totalQuestions,
                    CorrectAnswers = 4, // Khớp với 4/5 câu đúng
                    Score = 80.00m,
                    StartTime = user5StartTime,
                    EndTime = user5EndTime,
                    CreatedAt = user5EndTime
                });

                results.Add(new QuizResult
                {
                    QuizResultId = quizResultId++,
                    UserId = "6",
                    QuizId = quizId,
                    TotalQuestions = totalQuestions,
                    CorrectAnswers = 3, // Khớp với 3/5 câu đúng
                    Score = 60.00m,
                    StartTime = user6StartTime,
                    EndTime = user6EndTime,
                    CreatedAt = user6EndTime
                });
            }

            return results;
        }
    }
}