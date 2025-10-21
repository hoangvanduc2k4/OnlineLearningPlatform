using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class MentorApplicationService : IMentorApplicationService
    {
        private readonly IMentorApplicationRepository _mentorApplicationRepository;

        public MentorApplicationService(IMentorApplicationRepository mentorApplicationRepository)
        {
            _mentorApplicationRepository = mentorApplicationRepository;
        }

        public async Task CreateAsync(MentorApplication application)
        {
            await _mentorApplicationRepository.AddAsync(application);
        }

        public async Task<MentorApplication?> GetByIdAsync(long id)
        {
            return await _mentorApplicationRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<MentorApplication>> GetByUserIdAsync(string userId)
        {
            return await _mentorApplicationRepository.FindAsync(userId);
        }

        public async Task<IEnumerable<MentorApplication>> GetAllAsync()
        {
            return await _mentorApplicationRepository.GetAllAsync();
        }

        public async Task UpdateAsync(MentorApplication application)
        {
            await _mentorApplicationRepository.UpdateAsync(application);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            if (id > 0)
            {
                var application = await GetByIdAsync(id);
                    if(application != null)
                    await _mentorApplicationRepository.DeleteAsync(application);
            }
            return false;
        }
    }
}
