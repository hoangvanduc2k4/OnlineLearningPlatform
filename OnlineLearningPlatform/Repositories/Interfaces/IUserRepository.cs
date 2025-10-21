using OnlineLearningPlatform.Models.Entities.UserPart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<IEnumerable<User>> GetActiveUsersAsync(string? searchTerm);
        Task<IEnumerable<User>> GetAllUsersAsync(string? searchTerm);

        Task<User?> GetByEmailAndPasswordAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
        Task<User?> GetByEmailAsync(string email) { throw new NotImplementedException(); }

        Task<IEnumerable<User>> GetDeletedUsersAsync(string? searchTerm);
        Task<IEnumerable<User>> GetInactiveUsersAsync(string? searchTerm);

        Task<IEnumerable<User>> GetAllActiveMentorAsync(string? searchTerm);
        Task<List<User>> GetTopMentorsByStudentCountFromDbAsync(int count);
        Task<User?> GetByUserNameAsync(string userName);
    }
}
