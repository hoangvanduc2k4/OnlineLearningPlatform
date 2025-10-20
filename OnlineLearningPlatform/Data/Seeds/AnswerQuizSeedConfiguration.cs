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

            // Giả định: 155 quiz, mỗi quiz có 5 câu, mỗi câu có 4 option.
            // Giả định: Option đầu tiên của mỗi câu hỏi là đáp án đúng.
            // - User 5: đúng 4/5
            // - User 6: đúng 3/5
            // - User 7: đúng 5/5

            for (long quizId = 1; quizId <= 155; quizId++)
            {
                for (int q = 1; q <= 5; q++) // q là thứ tự câu hỏi trong quiz (từ 1 đến 5)
                {
                    long questionId = (quizId - 1) * 5 + q;

                    // Giả sử các OptionId được đánh số liên tiếp
                    // Option 1 (đúng) của questionId có ID là: (questionId * 4) - 3
                    // Option 2 (sai) của questionId có ID là: (questionId * 4) - 2
                    long correctOptionId = (questionId * 4) - 3;
                    long incorrectOptionId = (questionId * 4) - 2; // Chọn một đáp án sai cụ thể, logic hơn

                    // User 5 trả lời (đúng 4/5, sai câu cuối)
                    answers.Add(new AnswerQuiz
                    {
                        AnswerQuizId = answerId++,
                        UserId = "5",
                        QuestionId = questionId,
                        OptionId = (q == 5) ? incorrectOptionId : correctOptionId,
                        IsCorrect = (q != 5),
                        DateCreated = new DateTime(2025, 3, 1, 10, 0, 0)
                    });

                    // User 6 trả lời (đúng 3/5, đúng 3 câu đầu)
                    answers.Add(new AnswerQuiz
                    {
                        AnswerQuizId = answerId++,
                        UserId = "6",
                        QuestionId = questionId,
                        OptionId = (q <= 3) ? correctOptionId : incorrectOptionId,
                        IsCorrect = (q <= 3),
                        DateCreated = new DateTime(2025, 3, 2, 9, 30, 0)
                    });

                    // User 7 trả lời (đúng 5/5)
                    answers.Add(new AnswerQuiz
                    {
                        AnswerQuizId = answerId++,
                        UserId = "7",
                        QuestionId = questionId,
                        OptionId = correctOptionId, // Luôn chọn đáp án đúng
                        IsCorrect = true,           // Luôn đúng
                        DateCreated = new DateTime(2025, 3, 3, 11, 15, 0) // Thay đổi thời gian cho đa dạng
                    });
                }
            }

            return answers;
        }
    }
}