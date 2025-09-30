using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Services.Interfaces;
using OnlineLearningPlatform.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddUserAsync(User user)
        {
            return await _userRepository.AddAsync(user);
        }

        public async Task<bool> ChangeAvatarAsync(long userId, IFormFile avatarFile)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null || avatarFile == null) return false;

            // Implement avatar upload logic here (e.g., save file, update AvatarUrl)
            // Example: user.AvatarUrl = await SaveAvatarAsync(avatarFile);
            // For now, just return false as placeholder
            return false;
        }

        public async Task<bool> DeleteUserAsync(string userId)
        {
            if (userId == null) return false;
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null) return false;
            user.IsDeleted = true;
            await _userRepository.UpdateAsync(user);
            return true;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User?> GetByEmailAndPasswordAsync(string email, string password)
        {
            return await _userRepository.GetByEmailAndPasswordAsync(email, password);
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task<User?> GetUserByIdAsync(string id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<string> GetUserHeaderAsync(string userId)
        {
            var user = await GetUserByIdAsync(userId);
            return user?.FullName ?? string.Empty;
        }

        public async Task<string> GetUserNameByIdAsync(string userId)
        {
            var user = await GetUserByIdAsync(userId);
            return user?.FullName ?? string.Empty;
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
        }
    }
}