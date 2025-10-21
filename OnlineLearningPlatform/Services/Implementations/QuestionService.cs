using Microsoft.CodeAnalysis.Options;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public async Task CreateQuestionWithOptionsAsync(QuestionViewModel questionDTO, List<OptionsViewModel> optionsDTO, QuizViewModel quizDTO)
        {
            await _questionRepository.CreateQuestionAsync(questionDTO, optionsDTO, quizDTO);
        }

        public async Task DeleteQuestionAsync(long questionId)
        {
            var question = await _questionRepository.GetByIdAsync(questionId);
            if (question != null)
            {
                await _questionRepository.DeleteQuestionAsync(question);
            }
        }

        public async Task<IEnumerable<QuestionViewModel>> GetAllQuestionAsync()
        {
            var questions = await _questionRepository.GetAllAsync();

            var questionsDTO = questions.Select(q => new QuestionViewModel
            {
                QuestionId = q.QuestionId,
                QuizId = q.QuizId,
                QuestionContent = q.QuestionContent
            });

            return questionsDTO;
        }

        public async Task<List<QuestionWithOptionsViewModel>> GetAllQuestionsWithOptionsAsync()
        {
            var questions = await _questionRepository.GetAllAsync();

            var result = new List<QuestionWithOptionsViewModel>();

            foreach (var question in questions)
            {
                var options = await _questionRepository.GetOptionsByQuestionIdAsync(question.QuestionId);

                var questionWithOptions = new QuestionWithOptionsViewModel
                {
                    QuestionId = question.QuestionId,
                    QuizId = question.QuizId,
                    QuestionContent = question.QuestionContent,
                    Options = options.Select(o => new OptionsViewModel
                    {
                        OptionId = o.OptionId,
                        QuestionId = o.QuestionId,
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect
                    }).ToList()
                };

                result.Add(questionWithOptions);
            }

            return result;
        }

        public async Task<List<QuestionWithOptionsViewModel>> GetAllQuestionsWithOptionsByQuizIdAsync(long quizId)
        {
            var questions = await _questionRepository.GetAllAsync();

            questions = questions.Where(q => q.QuizId == quizId).ToList();

            var result = new List<QuestionWithOptionsViewModel>();

            foreach (var question in questions)
            {
                var options = await _questionRepository.GetOptionsByQuestionIdAsync(question.QuestionId);

                var questionWithOptions = new QuestionWithOptionsViewModel
                {
                    QuestionId = question.QuestionId,
                    QuizId = question.QuizId,
                    QuestionContent = question.QuestionContent,
                    Options = options.Select(o => new OptionsViewModel
                    {
                        OptionId = o.OptionId,
                        QuestionId = o.QuestionId,
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect
                    }).ToList()
                };

                result.Add(questionWithOptions);
            }

            return result;
        }

        public async Task<QuestionWithOptionsViewModel> GetQuestionWithOptionsById(long questionId)
        {
            var questionDTO = await _questionRepository.GetQuestionWithOptionsById(questionId);
            if (questionDTO == null)
            {
                return null;
            }

            var questionWithOptionsDTO = new QuestionWithOptionsViewModel
            {
                QuestionId = questionDTO.QuestionId,
                QuizId = questionDTO.QuizId,
                QuestionContent = questionDTO.QuestionContent,
                Options = questionDTO.Options
            };

            return questionWithOptionsDTO;
        }

        public async Task UpdateQuestionWithOptionsAsync(QuestionViewModel questionsDTO, List<OptionsViewModel> optionsDTO)
        {
            await _questionRepository.UpdateQuestionWithOptionsAsync(questionsDTO, optionsDTO);
        }
    }
}
