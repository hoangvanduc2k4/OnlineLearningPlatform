using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<IdentityRole>> GetAllAsync();
        Task<IdentityRole?> GetByIdAsync(string roleId);
        Task<IdentityRole?> GetByNameAsync(string roleName);
        Task<bool> CreateAsync(string roleName);
        Task<bool> DeleteAsync(string roleId);
        Task<bool> AddUserToRoleAsync(string userId, string roleName);
        Task<bool> RemoveUserFromRoleAsync(string userId, string roleName);
        Task<IList<string>> GetUserRolesAsync(string userId);
    }
}