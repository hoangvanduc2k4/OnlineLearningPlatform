using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _quizRepository;

        public async Task<Quiz> CreateQuizAsync(QuizViewModel quizDTO)
        {
            int convertedTime = quizDTO.QuizTime;
            if (quizDTO.TimeUnit == "minutes")
            {
                convertedTime = quizDTO.QuizTime * 60; // Chuyển phút sang giây
            }
            var quiz = new Quiz
            {

                QuizName = quizDTO.QuizName,
                ModuleId = quizDTO.ModuleId,
                QuizTime = convertedTime,
                PassScore = quizDTO.PassScore,
                Status = QuizStatus.Active
            };

            return await _quizRepository.AddAsync(quiz);
        }

        public async Task UpdateQuizAsync(QuizViewModel quizDTO)
        {
            // Lấy entity hiện có từ database thay vì tạo mới
            var existingQuiz = await _quizRepository.GetByIdAsync(quizDTO.QuizId);
            if (existingQuiz == null)
            {
                throw new Exception("Quiz không tồn tại");
            }

            // Cập nhật các thuộc tính của entity hiện có
            existingQuiz.QuizName = quizDTO.QuizName;
            existingQuiz.ModuleId = quizDTO.ModuleId;
            existingQuiz.QuizTime = quizDTO.QuizTime;
            existingQuiz.PassScore = quizDTO.PassScore;
            existingQuiz.UpdatedAt = DateTime.Now;

            // Lưu thay đổi
            await _quizRepository.UpdateAsync(existingQuiz);
        }

        public async Task DeleteQuizAsync(Quiz quiz)
        {
            await _quizRepository.DeleteAsync(quiz);
        }

        public async Task DeleteQuizByIdAsync(long quizId)
        {
            var quiz = await _quizRepository.GetByIdAsync(quizId);
            if (quiz != null)
            {
                await _quizRepository.DeleteAsync(quiz);
            }
        }

        public async Task<IEnumerable<QuizViewModel>> GetAllQuizAsync()
        {
            var quizzes = await _quizRepository.GetAllAsync();
            return quizzes.Select(q => new QuizViewModel
            {
                QuizId = q.QuizId,
                QuizName = q.QuizName,
                ModuleId = q.ModuleId,
                QuizTime = q.QuizTime ?? 0,
                PassScore = q.PassScore ?? 0
            });
        }

        public async Task<IEnumerable<QuizViewModel>> GetQuizzesByModuleIdAsync(long moduleId)
        {
            var quizzes = await _quizRepository.GetAllAsync();
            return quizzes
                .Where(q => q.ModuleId == moduleId)
                .Select(q => new QuizViewModel
                {
                    QuizId = q.QuizId,
                    QuizName = q.QuizName,
                    ModuleId = q.ModuleId,
                    QuizTime = q.QuizTime ?? 0,
                    PassScore = q.PassScore ?? 0
                });
        }

        public async Task<QuizViewModel> GetQuizByIdAsync(long quizId)
        {
            var quiz = await _quizRepository.GetByIdAsync(quizId);
            if (quiz == null) return null;

            return new QuizViewModel
            {
                QuizId = quiz.QuizId,
                QuizName = quiz.QuizName,
                ModuleId = quiz.ModuleId,
                QuizTime = quiz.QuizTime ?? 0,
                PassScore = quiz.PassScore ?? 0
            };
        }
    }
}
