using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public async Task<IEnumerable<Category>> GetAllCategoryAysnc()
        {
            return await _categoryRepository.GetAllAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(long id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _categoryRepository.AddAsync(category);
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            await _categoryRepository.UpdateAsync(category);
        }

        public async Task DeleteCategoryAsync(Category category)
        {
            category.IsDeleted = true;
            await _categoryRepository.UpdateAsync(category);
        }


        public async Task<IPagedList<Category>> GetCategoryPagedAdminAsync(int pageNumber, int pageSize, string? searchTerm = null)
        {

            IEnumerable<Category> filtered = await _categoryRepository.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lower = searchTerm.Trim().ToLower();
                filtered = filtered.Where(c =>
                    (!string.IsNullOrEmpty(c.CategoryName) && c.CategoryName.ToLower().Contains(lower))

                );
            }

            filtered = filtered.OrderBy(c => c.CategoryId);
            IPagedList<Category> pagedResult = filtered.ToPagedList(pageNumber, pageSize);
            return pagedResult;
        }

    }

}
