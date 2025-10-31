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


        public async Task<List<User>> GetTopMentorsByStudentCountFromDbAsync(int count)
        {
            var mentorsInRole = await _userManager.GetUsersInRoleAsync("Mentor");
            var mentorIds = mentorsInRole.Select(m => m.Id);
            var topMentorsQuery = _context.Users
                .AsNoTracking()
                .Where(u => mentorIds.Contains(u.Id) && u.IsActived && !u.IsDeleted)
                .Select(u => new
                {
                    User = u,
                    StudentCount = _context.CourseEnrollments
                                     .Where(ce => _context.Courses.Any(c => c.CourseId == ce.CourseId && c.Creator == u.Id))
                                     .Select(ce => ce.UserId)
                                     .Distinct()
                                     .Count()
                })
                .OrderByDescending(x => x.StudentCount)
                .Take(count)
                .Select(x => x.User);

            return await topMentorsQuery.ToListAsync();
        }

        public Task<User?> GetByUserNameAsync(string userName)
        {
            var query = _dbSet.AsNoTracking().Where(u => u.UserName == userName);
            return query.FirstOrDefaultAsync();
        }

        public async Task<int> GetTotalUsersCountAsync()
        {
            return await _userManager.Users.CountAsync();
        }

        public async Task<int> GetNewUsersCountOnDateAsync(DateTime date)
        {
            return await _userManager.Users.CountAsync(u => u.CreatedAt.Date == date.Date);
        }
    }
}
