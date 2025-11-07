using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System;
using System.Collections.Generic;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class AnswerQuizSeedConfiguration : IEntityTypeConfiguration<AnswerQuiz>
    {
        public void Configure(EntityTypeBuilder<AnswerQuiz> builder)
        {
            builder.HasData(GetAnswerQuizzes().ToArray());
        }

        private static List<AnswerQuiz> GetAnswerQuizzes()
        {
            var answers = new List<AnswerQuiz>();
            long answerId = 1;

            for (long quizId = 1; quizId <= 150; quizId++)
            {
                for (int q = 1; q <= 5; q++)
                {
                    long questionId = (quizId - 1) * 5 + q;

                    bool user5IsCorrect = (q != 5);
                    answers.Add(new AnswerQuiz
                    {
                        AnswerQuizId = answerId++,
                        UserId = "5",
                        QuestionId = questionId,
                        OptionId = (q == 5 ? (questionId * 4) - 2 : (questionId * 4) - 3),
                        IsCorrect = user5IsCorrect,
                        DateCreated = new DateTime(2025, 3, 1, 10, 0, 0)
                    });

                    bool user6IsCorrect = (q <= 3);
                    answers.Add(new AnswerQuiz
                    {
                        AnswerQuizId = answerId++,
                        UserId = "6",
                        QuestionId = questionId,
                        OptionId = (q <= 3 ? (questionId * 4) - 3 : (questionId * 4) - 2),
                        IsCorrect = user6IsCorrect,
                        DateCreated = new DateTime(2025, 3, 2, 9, 30, 0)
                    });
                }
            }

            return answers;
        }
    }
}