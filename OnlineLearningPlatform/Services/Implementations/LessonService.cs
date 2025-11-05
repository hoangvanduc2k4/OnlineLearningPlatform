using System.Threading.Tasks;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task<LessonViewModel?> GetLessonViewModelByIdAsync(long lessonId)
        {
            var lesson = await _lessonRepository.GetLessonByIdAsync(lessonId);
            if (lesson == null) return null;
            return new LessonViewModel
            {
                LessonId = lesson.LessonId,
                LessonName = lesson.LessonName,
                LessonNumber = lesson.LessonNumber,
                LessonContent = lesson.LessonContent,
                LessonVideo = lesson.LessonVideo,
                Duration = lesson.Duration
            };
        }
    }
}
