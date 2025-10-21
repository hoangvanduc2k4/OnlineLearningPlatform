using Microsoft.CodeAnalysis.Options;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IQuestionRepository:IBaseRepository<Question>
    {
        Task CreateQuestionAsync(QuestionViewModel questionDTO, List<OptionsViewModel> optionsDTO, QuizViewModel quizDTO);
        Task<List<Option>> GetOptionsByQuestionIdAsync(long questionId);
        Task DeleteQuestionAsync(Question question);

        // Phương thức lấy câu hỏi theo ID kèm theo các options
        Task<QuestionViewModel> GetQuestionWithOptionsById(long questionId);

        // Phương thức cập nhật câu hỏi kèm theo các options
        Task UpdateQuestionWithOptionsAsync(QuestionViewModel questionDTO, List<OptionsViewModel> optionsDTO);

        // Phương thức lấy tất cả câu hỏi kèm theo các options
        Task<List<QuestionViewModel>> GetAllQuestionsWithOptionsAsync();
    }
}
