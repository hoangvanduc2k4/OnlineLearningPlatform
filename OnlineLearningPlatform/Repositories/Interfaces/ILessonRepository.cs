using OnlineLearningPlatform.Models.Entities.CoursePart;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface ILessonRepository : IBaseRepository<Lesson>
    {
        Task<Lesson?> GetLessonByIdAsync(long lessonId);
        Task<IEnumerable<Lesson>> GetLessonsByModuleIdAsync(long moduleId);
        Task<Lesson?> GetLessonWithCourseAsync(long lessonId, string mentorId);
    }
}
