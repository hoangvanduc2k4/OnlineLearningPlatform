using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class ModuleRepository : BaseRepository<Module>, IModuleRepository
    {
        private new readonly OnlineLearningDBContext _context;
        
        public ModuleRepository(OnlineLearningDBContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Module?> GetModuleForEditAsync(long moduleId, string mentorId)
        {
            return await _context.Modules
                .Include(m => m.Course) 
                .FirstOrDefaultAsync(m => m.ModuleId == moduleId && m.Course.Creator == mentorId);
        }
    }
}
