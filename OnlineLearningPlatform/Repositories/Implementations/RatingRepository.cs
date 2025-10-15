// OnlineLearningPlatform/Repositories/RatingRepository.cs
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly OnlineLearningDBContext _context;

        public RatingRepository(OnlineLearningDBContext context)
        {
            _context = context;
        }

        public async Task<List<Ratings>> GetRatingsByCourseIdAsync(long courseId)
        {
            return await _context.Ratings
                                 .Where(r => r.CourseId == courseId)
                                 .Include(r => r.User)
                                 .OrderByDescending(r => r.DateCreated)
                                 .ToListAsync();
        }
    }
}