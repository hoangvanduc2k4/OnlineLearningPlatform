using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<IEnumerable<IdentityRole>> GetAllRolesAsync()
            => await _roleRepository.GetAllAsync();

        public async Task<IdentityRole?> GetRoleByIdAsync(string roleId)
            => await _roleRepository.GetByIdAsync(roleId);

        public async Task<IdentityRole?> GetRoleByNameAsync(string roleName)
            => await _roleRepository.GetByNameAsync(roleName);

        public async Task<bool> CreateRoleAsync(string roleName)
            => await _roleRepository.CreateAsync(roleName);

        public async Task<bool> DeleteRoleAsync(string roleId)
            => await _roleRepository.DeleteAsync(roleId);

        public async Task<bool> AddUserToRoleAsync(string userId, string roleName)
            => await _roleRepository.AddUserToRoleAsync(userId, roleName);

        public async Task<bool> RemoveUserFromRoleAsync(string userId, string roleName)
            => await _roleRepository.RemoveUserFromRoleAsync(userId, roleName);

        public async Task<IList<string>> GetUserRolesAsync(string userId)
            => await _roleRepository.GetUserRolesAsync(userId);
    }
}