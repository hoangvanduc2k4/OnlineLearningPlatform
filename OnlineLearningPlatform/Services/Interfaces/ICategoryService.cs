using OnlineLearningPlatform.Models.Entities.CoursePart;
using X.PagedList;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoryAysnc();
        Task<Category> GetCategoryByIdAsync(long id);
        Task AddCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(Category category);
        Task<IPagedList<Category>> GetCategoryPagedAdminAsync(int pageNumber, int pageSize, string? searchTerm = null);


    }
}
