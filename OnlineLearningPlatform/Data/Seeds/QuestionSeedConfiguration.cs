using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System;
using System.Collections.Generic;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class QuestionSeedConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(GetQuestions().ToArray());
        }

        private static List<Question> GetQuestions()
        {
            var questions = new List<Question>();
            long questionId = 1;
            var baseDate = new DateTime(2025, 1, 1);

            for (long quizId = 1; quizId <= 150; quizId++)
            {
                var createdDate = baseDate.AddDays((quizId - 1) / 3);

                for (int q = 1; q <= 5; q++)
                {
                    questions.Add(new Question
                    {
                        QuestionId = questionId++,
                        QuestionNum = q,
                        QuizId = quizId,
                        QuestionContent = $"Question {q} for Quiz {quizId}",
                        DateCreated = createdDate
                    });
                }
            }

            return questions;
        }
    }
}