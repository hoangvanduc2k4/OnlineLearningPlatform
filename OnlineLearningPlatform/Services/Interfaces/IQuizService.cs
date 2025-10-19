using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IQuizService
    {
        Task<Quiz> CreateQuizAsync(QuizViewModel quizDTO);
        Task UpdateQuizAsync(QuizViewModel quizDTO);
        Task DeleteQuizAsync(Quiz quiz);
        Task DeleteQuizByIdAsync(long quizId);
        Task<IEnumerable<QuizViewModel>> GetAllQuizAsync();
        Task<IEnumerable<QuizViewModel>> GetQuizzesByModuleIdAsync(long moduleId);
        Task<QuizViewModel> GetQuizByIdAsync(long quizId);
    }
}
