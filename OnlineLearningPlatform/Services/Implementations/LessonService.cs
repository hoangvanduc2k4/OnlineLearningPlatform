using AutoMapper;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using System.Threading.Tasks;

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

        public async Task<LessonInputViewModel?> GetLessonForEditAsync(long lessonId, string mentorId)
        {
            var lesson = await _lessonRepository.GetLessonWithCourseAsync(lessonId, mentorId);

            if (lesson == null) return null;

            return _mapper.Map<LessonInputViewModel>(lesson);
        }

        public async Task<bool> UpdateLessonAsync(LessonInputViewModel viewModel, string mentorId)
        {
            var entityFromDb = await _lessonRepository.GetLessonWithCourseAsync(viewModel.LessonId, mentorId);

            if (entityFromDb == null) return false;

            _mapper.Map(viewModel, entityFromDb);
            entityFromDb.ModifiedDate = DateTime.Now;

            await _lessonRepository.UpdateAsync(entityFromDb);
            return true;
        }

        public async Task<bool> HideLessonAsync(long lessonId, string mentorId)
        {
            var lesson = await _lessonRepository.GetLessonWithCourseAsync(lessonId, mentorId);

            if (lesson == null)
            {
                return false; 
            }

            lesson.Status = CommonStatus.Hided;

            await _lessonRepository.UpdateAsync(lesson);
            return true;
        }
    }
}
