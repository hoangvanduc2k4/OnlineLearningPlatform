using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.ViewModels;
using X.PagedList;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IFAQsService
    {
        Task AddAsync(FAQ faq);
        Task<IEnumerable<FAQ>> GetAllAsync();
        Task<FAQ?> GetByIdAsync(long id);
        Task UpdateAsync(FAQ faq);
        Task DeleteAsync(FAQ faq);
        Task<bool> IsFAQExists(long id);
        Task<IPagedList<FAQsViewModel>> GetFAQsPagedAsync(int pageNumber, int pageSize, string? searchTerm = null);
        Task<IPagedList<FAQ>> GetFAQsPagedAdminAsync(int pageNumber, int pageSize, string? searchTerm = null);

    }

}
