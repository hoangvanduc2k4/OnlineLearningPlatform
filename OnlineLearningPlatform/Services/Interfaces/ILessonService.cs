using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ILessonService
    {
        Task CreateLessonAsync(LessonInputViewModel viewModel);
    }
}
