using AutoMapper;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using System.Threading.Tasks;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly IMapper _mapper;

        public LessonService(ILessonRepository lessonRepository, IMapper mapper)
        {
            _lessonRepository = lessonRepository;
            _mapper = mapper;
        }

        public async Task CreateLessonAsync(LessonInputViewModel viewModel)
        {
            var lesson = _mapper.Map<Lesson>(viewModel);

            lesson.DateCreated = DateTime.Now;
            lesson.ModifiedDate = DateTime.Now;

            await _lessonRepository.AddAsync(lesson);
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
