using OnlineLearningPlatform.Models.Entities.UserPart;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetUserByIdAsync(long? id);
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<User?> GetByEmailAndPasswordAsync(string email, string password);

        Task<User?> GetUserByEmailAsync(string email);

        Task<User> AddUserAsync(User user);

        Task UpdateUserAsync(User user);
        //Task<bool> UpdateProfileAsync(ProfileDTO profile);
        Task<bool> ChangeAvatarAsync(long userId, IFormFile avatarFile);
        Task<string> GetUserHeaderAsync(long? userId);
        //Task<bool> ChangePasswordAsync(long userId, ChangePassDTO changePassDTO);

        Task<string> GetUserNameByIdAsync(long? userId);
    }
}
