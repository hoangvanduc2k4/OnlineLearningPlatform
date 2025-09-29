using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ILevelService
    {
        Task<IEnumerable<Level>> GetAllLevelAysnc();
        Task<Level> GetLevelByIdAsync(long id);
        Task AddLevelAsync(Level level);
        Task UpdateLevelAsync(Level level);
        Task DeleteLevelAsync(Level level);
    }

}
