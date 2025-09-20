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

            // Giả sử: 12 quiz, mỗi quiz có 5 câu, mỗi câu có 4 option
            // User 3 và User 4 đều làm quiz
            // User 3: đúng 4/5
            // User 4: đúng 3/5

            for (long quizId = 1; quizId <= 12; quizId++)
            {
                for (int q = 1; q <= 5; q++)
                {
                    long questionId = (quizId - 1) * 5 + q;

                    // User 3 trả lời
                    answers.Add(new AnswerQuiz
                    {
                        AnswerQuizId = answerId++,
                        UserId = "3",
                        QuestionId = questionId,
                        OptionId = (q == 5 ? (questionId * 4) - 3 : (questionId * 4) - 4), // option đầu là đúng
                        IsCorrect = (q != 5), // sai câu cuối
                        DateCreated = new DateTime(2025, 3, 1, 10, 0, 0)
                    });

                    // User 4 trả lời
                    answers.Add(new AnswerQuiz
                    {
                        AnswerQuizId = answerId++,
                        UserId = "4",
                        QuestionId = questionId,
                        OptionId = (q <= 3 ? (questionId * 4) - 4 : (questionId * 4) - 3), // đúng 3 câu đầu
                        IsCorrect = (q <= 3),
                        DateCreated = new DateTime(2025, 3, 2, 9, 30, 0)
                    });
                }
            }

            return answers;
        }
    }
}
