using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using X.PagedList;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetUserByIdAsync(string id);
        Task<User?> GetUserByNameAsync(string userName);
        Task<IEnumerable<User>> GetActiveUsersAsync(string? searchTerm);
        Task<IEnumerable<User>> GetInactiveUsersAsync(string? searchTerm);
        Task<IEnumerable<User>> GetDeletedUsersAsync(string? searchTerm);
        Task<IEnumerable<User>> GetAllUsersAsync(string? searchTerm);

        Task<User?> GetByEmailAndPasswordAsync(string email, string password);

        Task<User?> GetUserByEmailAsync(string email);

        Task<User> AddUserAsync(User user);

        Task UpdateUserAsync(User user);
        //Task<bool> UpdateProfileAsync(ProfileDTO profile);
        Task<bool> DeleteUserAsync(string userId);

        Task<bool> ChangeAvatarAsync(long userId, IFormFile avatarFile);
        Task<string> GetUserHeaderAsync(string userId);
        //Task<bool> ChangePasswordAsync(long userId, ChangePassDTO changePassDTO);

        Task<string> GetUserNameByIdAsync(string userId);

        Task<IEnumerable<User>> GetAllActiveMentorAsync(string? searchTerm);

        Task<IPagedList<InstructorViewModel>> GetPaginatedMentorsAsync(string searchString, int page, int pageSize, string? sortBy = null, string? orderBy = "desc");


        Task<List<InstructorViewModel>> GetTopMentorsByStudentCountAsync(int count);
    }
}
