using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(OnlineLearningDBContext context) : base(context)
        {
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
