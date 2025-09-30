using OnlineLearningPlatform.Models.Entities.UserPart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User?> GetByEmailAndPasswordAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
        Task<User?> GetByEmailAsync(string email) { throw new NotImplementedException(); }
    }
}
