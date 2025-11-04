using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface ILessonRepository : IBaseRepository<Lesson>
    {
        Task<Lesson?> GetLessonByIdAsync(long lessonId);
        Task<IEnumerable<Lesson>> GetLessonsByModuleIdAsync(long moduleId);
    }
}
