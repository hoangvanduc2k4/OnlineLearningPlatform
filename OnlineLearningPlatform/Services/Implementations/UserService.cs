using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class UserService : IUserService
    {
        public Task<User> AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangeAvatarAsync(long userId, IFormFile avatarFile)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByEmailAndPasswordAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetUserByIdAsync(long? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserHeaderAsync(long? userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameByIdAsync(long? userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
