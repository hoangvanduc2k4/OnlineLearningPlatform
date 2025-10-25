using OnlineLearningPlatform.Models.Entities.Others;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IMentorApplicationService
    {
        Task CreateAsync(MentorApplication application);
        Task<MentorApplication?> GetByIdAsync(long id);
        Task<IEnumerable<MentorApplication>> GetByUserIdAsync(string userId);
        Task<IEnumerable<MentorApplication>> GetAllAsync();
        Task UpdateAsync(MentorApplication application);
        Task<bool> DeleteAsync(long id);
    }
}
