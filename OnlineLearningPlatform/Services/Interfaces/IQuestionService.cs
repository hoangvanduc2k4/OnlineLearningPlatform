using Microsoft.CodeAnalysis.Options;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IQuestionService
    {
        Task CreateQuestionWithOptionsAsync(QuestionViewModel questionDTO, List<OptionsViewModel> optionsDTO, QuizViewModel quizDTO);
        //Task<Question> CreateQuestionAsync(QuestionsDTO questionsDTO);
        //Task UpdateQuestionAsync(QuestionsDTO questionsDTO);
        Task UpdateQuestionWithOptionsAsync(QuestionViewModel questionsDTO, List<OptionsViewModel> optionsDTO);
        Task DeleteQuestionAsync(long questionId);
        Task<IEnumerable<QuestionViewModel>> GetAllQuestionAsync();
        Task<List<QuestionWithOptionsViewModel>> GetAllQuestionsWithOptionsAsync();
        Task<QuestionWithOptionsViewModel> GetQuestionWithOptionsById(long questionId);
        Task<List<QuestionWithOptionsViewModel>> GetAllQuestionsWithOptionsByQuizIdAsync(long quizId);
    }
}
