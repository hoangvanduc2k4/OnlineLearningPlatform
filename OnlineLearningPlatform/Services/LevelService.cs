using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services
{
    public class LevelService : ILevelService
    {
        private readonly ILevelRepository _levelRepository;

        public LevelService(ILevelRepository levelRepository)
        {
            _levelRepository = levelRepository;
        }

        public async Task<IEnumerable<Level>> GetAllLevelAysnc()
        {
            return await _levelRepository.GetAllAsync();
        }
        public async Task<Level> GetLevelByIdAsync(long id)
        {
            return await _levelRepository.GetByIdAsync(id);
        }

        public async Task AddLevelAsync(Level level)
        {
            await _levelRepository.AddAsync(level);
        }

        public async Task UpdateLevelAsync(Level level)
        {
            await _levelRepository.UpdateAsync(level);
        }

        public async Task DeleteLevelAsync(Level level)
        {
            level.IsDeleted = true;
            await _levelRepository.UpdateAsync(level);
        }
    }

}
