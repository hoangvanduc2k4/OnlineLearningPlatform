using System.Threading.Tasks;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ILessonService 
    {
        Task<LessonViewModel?> GetLessonViewModelByIdAsync(long lessonId);
        Task CreateLessonAsync(LessonInputViewModel viewModel);
        Task<LessonInputViewModel?> GetLessonForEditAsync(long lessonId, string mentorId);
        Task<bool> UpdateLessonAsync(LessonInputViewModel viewModel, string mentorId);
    }
}
