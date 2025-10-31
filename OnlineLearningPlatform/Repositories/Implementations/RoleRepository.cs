using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Models.Entities.UserPart.User> _userManager;
        private readonly OnlineLearningDBContext _context;
        public RoleRepository(RoleManager<IdentityRole> roleManager, UserManager<Models.Entities.UserPart.User> userManager, OnlineLearningDBContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IEnumerable<IdentityRole>> GetAllAsync()
        {
            return _roleManager.Roles;

        }

        public async Task<IdentityRole?> GetByIdAsync(string roleId)
        {
            return await _roleManager.FindByIdAsync(roleId);
        }

        public async Task<IdentityRole?> GetByNameAsync(string roleName)
        {
            return await _roleManager.FindByNameAsync(roleName);
        }

        public async Task<bool> CreateAsync(string roleName)
        {
            var result = await _roleManager.CreateAsync(new IdentityRole(roleName));
            return result.Succeeded;
        }

        public async Task<bool> DeleteAsync(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null) return false;
            var result = await _roleManager.DeleteAsync(role);
            return result.Succeeded;
        }

        public async Task<bool> AddUserToRoleAsync(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return false;
            var result = await _userManager.AddToRoleAsync(user, roleName);
            return result.Succeeded;
        }

        public async Task<bool> RemoveUserFromRoleAsync(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return false;
            var result = await _userManager.RemoveFromRoleAsync(user, roleName);
            return result.Succeeded;
        }

        public async Task<IList<string>> GetUserRolesAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return new List<string>();
            return await _userManager.GetRolesAsync(user);
        }

        public Task<IList<string>> GetUserIdsInRoleAsync(string selectedRole)
        {
            var usersInRole = _userManager.GetUsersInRoleAsync(selectedRole);
            return usersInRole.ContinueWith(task =>
            {
                var users = task.Result;
                IList<string> userIds = new List<string>();
                foreach (var user in users)
                {
                    userIds.Add(user.Id);
                }
                return userIds;
            });
        }

        public async Task<Dictionary<string, int>> GetUserCountsByRoleAsync()
        {
            return await _context.UserRoles
                .GroupBy(ur => ur.RoleId)
                .Select(g => new { RoleId = g.Key, Count = g.Count() })
                .Join(_context.Roles,
                      userRoleGroup => userRoleGroup.RoleId,
                      role => role.Id,
                      (userRoleGroup, role) => new { RoleName = role.Name, Count = userRoleGroup.Count })
                .Where(r => r.RoleName != null)
                .ToDictionaryAsync(r => r.RoleName!, r => r.Count);
        }

    }
}