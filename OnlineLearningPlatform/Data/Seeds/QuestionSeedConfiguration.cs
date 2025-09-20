using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.CoursePart;

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

            // Mỗi quiz có 5 câu hỏi
            for (long quizId = 1; quizId <= 12; quizId++)
            {
                for (int q = 1; q <= 5; q++)
                {
                    questions.Add(new Question
                    {
                        QuestionId = questionId++,
                        QuestionNum = q,
                        QuizId = quizId,
                        QuestionContent = $"Question {q} for Quiz {quizId}",
                        DateCreated = new DateTime(2025, 1, 1)
                    });
                }
            }

            return questions;
        }
    }
}
