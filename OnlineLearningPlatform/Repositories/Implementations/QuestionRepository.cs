using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(OnlineLearningDBContext context) : base(context)
        {
        }

        public async Task CreateQuestionAsync(QuestionViewModel questionDTO, List<OptionsViewModel> optionsDTO, QuizViewModel quizDTO)
        {
            var quizExists = await _context.Quizzes.AnyAsync(q => q.QuizId == quizDTO.QuizId);
            if (!quizExists)
            {
                throw new Exception($"Quiz với ID {questionDTO.QuizId} không tồn tại. Không thể thêm câu hỏi cho Quiz không tồn tại.");
            }

            var question = new Question
            {
                QuizId = quizDTO.QuizId,
                QuestionContent = questionDTO.QuestionContent,
                //CreatedAt = questionDTO.CreatedAt,
                //UpdatedAt = questionDTO.UpdatedAt,
                //Status = questionDTO.Status
            };

            await _context.Questions.AddAsync(question);
            await _context.SaveChangesAsync();

            var options = optionsDTO.Select(o => new Option
            {
                QuestionId = question.QuestionId, // Gán QuestionId từ Question vừa lưu
                OptionText = o.OptionText,
                IsCorrect = o.IsCorrect,
                //CreatedAt = o.CreatedAt,
                //UpdatedAt = o.UpdatedAt,
                //Status = o.Status
            }).ToList();

            await _context.Options.AddRangeAsync(options);
            await _context.SaveChangesAsync();
        }

        public async Task  DeleteQuestionAsync(Question question)
        {
            var options = await _context.Options
                .Where(o => o.QuestionId == question.QuestionId)
                .ToListAsync();

            if (options.Any())
            {
                _context.Options.RemoveRange(options);
                await _context.SaveChangesAsync();
            }

            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
        }

        public async Task<List<QuestionViewModel>> GetAllQuestionsWithOptionsAsync()
        {
            var questions = await _context.Questions.ToListAsync();
            var result = new List<QuestionViewModel>();

            foreach (var question in questions)
            {
                var options = await _context.Options
                    .Where(o => o.QuestionId == question.QuestionId)
                    .ToListAsync();

                var questionDTO = new QuestionViewModel
                {
                    QuestionId = question.QuestionId,
                    QuizId = question.QuizId,
                    QuestionContent = question.QuestionContent,
                    Options = options.Select(o => new OptionsViewModel
                    {
                        OptionId = o.OptionId,
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect,
                        QuestionId = o.QuestionId
                    }).ToList()
                };

                result.Add(questionDTO);
            }

            return result;
        }

        public async Task<List<Option>> GetOptionsByQuestionIdAsync(long questionId)
        {
            return await _context.Options
               .Where(o => o.QuestionId == questionId)
               .ToListAsync();
        }

        public async Task<QuestionViewModel> GetQuestionWithOptionsById(long questionId)
        {
            var question = await _context.Questions
                .Where(q => q.QuestionId == questionId)
                .FirstOrDefaultAsync();

            if (question == null)
            {
                return null;
            }

            var options = await _context.Options
                .Where(o => o.QuestionId == questionId)
                .ToListAsync();

            var questionDTO = new QuestionViewModel
            {
                QuestionId = question.QuestionId,
                QuizId = question.QuizId,
                QuestionContent = question.QuestionContent,
                Options = options.Select(o => new OptionsViewModel
                {
                    OptionId = o.OptionId,
                    OptionText = o.OptionText,
                    IsCorrect = o.IsCorrect,
                    QuestionId = o.QuestionId
                }).ToList()
            };

            return questionDTO;
        }

        public async Task UpdateQuestionWithOptionsAsync(QuestionViewModel questionDTO, List<OptionsViewModel> optionsDTO)
        {
            var question = await _context.Questions.FindAsync(questionDTO.QuestionId);
            if (question == null)
            {
                throw new Exception($"Không tìm thấy câu hỏi có ID: {questionDTO.QuestionId}");
            }

            var quizExists = await _context.Quizzes.AnyAsync(q => q.QuizId == questionDTO.QuizId);
            if (!quizExists)
            {
                throw new Exception($"Quiz với ID {questionDTO.QuizId} không tồn tại. Không thể cập nhật câu hỏi cho Quiz không tồn tại.");
            }

            question.QuestionContent = questionDTO.QuestionContent;
            //question.UpdatedAt = DateTime.Now;

            var existingOptions = await _context.Options
                .Where(o => o.QuestionId == questionDTO.QuestionId)
                .ToListAsync();

            var newOptions = optionsDTO.Where(o => o.OptionId == 0).ToList();

            var updatingOptions = optionsDTO.Where(o => o.OptionId != 0).ToList();
            var updatingOptionIds = updatingOptions.Select(o => o.OptionId).ToList();

            var deletingOptions = existingOptions.Where(eo => !updatingOptionIds.Contains(eo.OptionId)).ToList();

            if (deletingOptions.Any())
            {
                _context.Options.RemoveRange(deletingOptions);
            }

            foreach (var updatingOption in updatingOptions)
            {
                var existingOption = existingOptions.FirstOrDefault(eo => eo.OptionId == updatingOption.OptionId);
                if (existingOption != null)
                {
                    existingOption.OptionText = updatingOption.OptionText;
                    existingOption.IsCorrect = updatingOption.IsCorrect;
                    //existingOption.UpdatedAt = DateTime.Now;
                }
            }

            if (newOptions.Any())
            {
                var newOptionEntities = newOptions.Select(o => new Option
                {
                    QuestionId = questionDTO.QuestionId,
                    OptionText = o.OptionText,
                    IsCorrect = o.IsCorrect,
                    //CreatedAt = DateTime.Now,
                    //UpdatedAt = DateTime.Now,
                    //Status = o.Status
                }).ToList();

                await _context.Options.AddRangeAsync(newOptionEntities);
            }

            await _context.SaveChangesAsync();
        }
    }
}
