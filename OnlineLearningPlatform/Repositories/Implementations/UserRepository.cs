using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        private readonly UserManager<User> _userManager;
        public UserRepository(OnlineLearningDBContext context, UserManager<User> userManager) : base(context)
        {
            _userManager = userManager;
        }

        public async Task<IEnumerable<User>> GetActiveUsersAsync(string? searchTerm)
        {
            var query = _dbSet.AsNoTracking().Where(u => u.IsActived && !u.IsDeleted);
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(u =>
                    (u.Email != null && EF.Functions.Like(u.Email, $"%{searchTerm}%")) ||
                    (u.FullName != null && EF.Functions.Like(u.FullName, $"%{searchTerm}%"))
                );
            }
            return await query.OrderByDescending(u => u.CreatedAt).ToListAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(string? searchTerm)
        {
            var query = _dbSet.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(u =>
                    (u.Email != null && EF.Functions.Like(u.Email, $"%{searchTerm}%")) ||
                    (u.FullName != null && EF.Functions.Like(u.FullName, $"%{searchTerm}%"))
                );
            }
            return await query.OrderByDescending(u => u.CreatedAt).ToListAsync();
        }

        public async Task<IEnumerable<User>> GetDeletedUsersAsync(string? searchTerm)
        {
            var query = _dbSet.AsNoTracking().Where(u => u.IsDeleted);
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(u =>
                    (u.Email != null && EF.Functions.Like(u.Email, $"%{searchTerm}%")) ||
                    (u.FullName != null && EF.Functions.Like(u.FullName, $"%{searchTerm}%"))
                );
            }
            return await query.OrderByDescending(u => u.CreatedAt).ToListAsync();
        }

        public async Task<IEnumerable<User>> GetAllActiveMentorAsync(string? searchTerm)
        {
            var mentorsInRole = await _userManager.GetUsersInRoleAsync("Mentor");

            var mentorIds = mentorsInRole.Select(m => m.Id).ToList();

            var query = _context.Users
                .AsNoTracking()
                .Where(u => mentorIds.Contains(u.Id)
                         && u.IsActived
                         && !u.IsDeleted);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(u =>
                    (u.Email != null && EF.Functions.Like(u.Email, $"%{searchTerm}%")) ||
                    (u.FullName != null && EF.Functions.Like(u.FullName, $"%{searchTerm}%"))
                );
            }

            return await query.OrderByDescending(u => u.CreatedAt).ToListAsync();
        }

        public async Task<IEnumerable<User>> GetInactiveUsersAsync(string? searchTerm)
        {
            var query = _dbSet.AsNoTracking().Where(u => !u.IsActived && !u.IsDeleted);
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(u =>
                    (u.Email != null && EF.Functions.Like(u.Email, $"%{searchTerm}%")) ||
                    (u.FullName != null && EF.Functions.Like(u.FullName, $"%{searchTerm}%"))
                );
            }
            return await query.OrderByDescending(u => u.CreatedAt).ToListAsync();
        }
    }
}
