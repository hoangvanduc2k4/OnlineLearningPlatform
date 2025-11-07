using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IQuizService
    {
        Task<Quiz> GetQuizAsync(long quizId);
        Task<Quiz> CreateQuizAsync(QuizViewModel quizDTO);
        Task UpdateQuizAsync(QuizViewModel quizDTO);
        Task DeleteQuizAsync(Quiz quiz);
        Task DeleteQuizByIdAsync(long quizId);
        Task<IEnumerable<QuizViewModel>> GetAllQuizAsync();
        Task<IEnumerable<QuizViewModel>> GetQuizzesByModuleIdAsync(long moduleId);
        Task<QuizViewModel> GetQuizByIdAsync(long quizId,string currentUserId);
        Task<IEnumerable<QuizViewModel>> GetActiveQuizzesAsync(string? searchTerm, string currentUserId, string role);
        Task<IEnumerable<QuizViewModel>> GetInactiveQuizzesAsync(string? searchTerm, string currentUserId, string role);
        Task<bool> HideQuizAsync(long quizId, string mentorId);
    }
}
