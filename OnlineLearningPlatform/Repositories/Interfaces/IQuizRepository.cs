using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IQuizRepository: IBaseRepository<Quiz>
    {
        Task<IEnumerable<Quiz>> GetAllWithModuleAndCourseAsync();
        Task<Quiz?> GetByIdWithCourseAsync(long id);
    }
}
