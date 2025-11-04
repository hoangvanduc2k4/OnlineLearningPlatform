using System.Threading.Tasks;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ILessonService 
    {
        Task<LessonViewModel?> GetLessonViewModelByIdAsync(long lessonId);
    }
}
