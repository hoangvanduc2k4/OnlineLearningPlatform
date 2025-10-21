using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class MentorApplicationRepository : BaseRepository<MentorApplication>, IMentorApplicationRepository
    {
        public MentorApplicationRepository(OnlineLearningDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable<MentorApplication>> FindAsync(string userId)
        {
            var query = _context.MentorApplications.AsQueryable();
            query = query.Where(ma => ma.UserId == userId);
            return await query.ToListAsync();
        }

        // Add custom MentorApplication-specific methods here if needed in the future
    }
}
