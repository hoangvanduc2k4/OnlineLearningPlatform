using AutoMapper;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
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
    }
}
