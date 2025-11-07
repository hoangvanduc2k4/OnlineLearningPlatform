using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IModuleRepository : IBaseRepository<Module>
    {
        Task<Module?> GetModuleForEditAsync(long moduleId, string mentorId);
    }
}
