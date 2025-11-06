using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository _moduleRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public ModuleService(
            IModuleRepository moduleRepository,
            ICourseRepository courseRepository,
            IMapper mapper)
        {
            _moduleRepository = moduleRepository;
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task CreateModuleAsync(ModuleInputViewModel viewModel)
        {
            var newModule = _mapper.Map<Module>(viewModel);

            newModule.DateCreated = DateTime.Now;
            newModule.ModifiedDate = DateTime.Now;

            await _moduleRepository.AddAsync(newModule); 
        }

        public async Task<IEnumerable<SelectListItem>> GetCoursesForDropdownAsync(string mentorId)
        {
            var courses = await _courseRepository.GetAllByMentorIdAsync(mentorId);

            var selectList = courses.Select(c => new SelectListItem
            {
                Value = c.CourseId.ToString(),
                Text = c.CourseName
            }).ToList();

            return selectList;
        }

        public async Task<ModuleInputViewModel?> GetModuleForEditAsync(long moduleId, string mentorId)
        {
            var module = await _moduleRepository.GetModuleForEditAsync(moduleId, mentorId);
            if (module == null)
            {
                return null; 
            }

            return _mapper.Map<ModuleInputViewModel>(module);
        }

        public async Task<bool> UpdateModuleAsync(ModuleInputViewModel viewModel, string mentorId)
        {
            var entityFromDb = await _moduleRepository.GetModuleForEditAsync(viewModel.ModuleId, mentorId);

            if (entityFromDb == null)
            {
                return false; 
            }

            _mapper.Map(viewModel, entityFromDb);

            entityFromDb.ModifiedDate = DateTime.Now;

            await _moduleRepository.UpdateAsync(entityFromDb);
            return true;
        }
    }
}
