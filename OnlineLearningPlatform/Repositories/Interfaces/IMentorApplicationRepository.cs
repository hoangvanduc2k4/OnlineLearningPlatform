using OnlineLearningPlatform.Models.Entities.Others;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IMentorApplicationRepository : IBaseRepository<MentorApplication>
    {
        Task<IEnumerable<MentorApplication>> FindAsync(string userId);
    }
}
