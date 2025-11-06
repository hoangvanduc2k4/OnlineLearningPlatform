using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface ILevelRepository : IBaseRepository<Level>
    {
        Task<IEnumerable<Level>> GetAllActiveAsync();
        Task<Level?> GetLevelByNameAsync(string levelName);

    }
}
