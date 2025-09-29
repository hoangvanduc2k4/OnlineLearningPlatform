using AutoMapper;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Services
{
    public class FAQsService : IFAQsService
    {

        private readonly IFAQsRepository _faqsRepository;
        private readonly IMapper _mapper;

        public FAQsService(IFAQsRepository faqsRepository, IMapper mapper)
        {
            _faqsRepository = faqsRepository;
            _mapper = mapper;
        }
        public async Task AddAsync(FAQ faq)
        {
            faq.CreatedAt = DateTime.Now;
            faq.UpdatedAt = DateTime.Now;
            await _faqsRepository.AddAsync(faq);
        }

        public async Task DeleteAsync(FAQ faq)
        {
            await _faqsRepository.DeleteAsync(faq);
        }

        public async Task<IEnumerable<FAQ>> GetAllAsync()
        {
            return await _faqsRepository.GetAllAsync();
        }

        public async Task<FAQ?> GetByIdAsync(long id)
        {
            return await _faqsRepository.GetByIdAsync(id);
        }

        public async Task<bool> IsFAQExists(long id)
        {
            var faq = await GetByIdAsync(id);
            return faq != null;
        }


        public async Task UpdateAsync(FAQ faq)
        {
            var existingFaq = await _faqsRepository.GetByIdAsync(faq.FaqId);
            if (existingFaq == null)
            {
                throw new Exception("FAQ not found");
            }
            existingFaq.Question = faq.Question;
            existingFaq.Answer = faq.Answer;
            existingFaq.CommonStatus = faq.CommonStatus;
            existingFaq.UpdatedAt = DateTime.Now;

            await _faqsRepository.UpdateAsync(existingFaq);
        }
        public async Task<IPagedList<FAQsViewModel>> GetFAQsPagedAsync(int pageNumber, int pageSize, string? searchTerm = null)
        {
            IEnumerable<FAQ> allFaqs = await _faqsRepository.GetAllAsync();

            IEnumerable<FAQ> filtered = allFaqs.Where(f => f.CommonStatus == Enums.CommonStatus.Showed);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lower = searchTerm.Trim().ToLower();
                filtered = filtered.Where(f =>
                    (!string.IsNullOrEmpty(f.Question) && f.Question.ToLower().Contains(lower))
                    ||
                    (!string.IsNullOrEmpty(f.Answer) && f.Answer.ToLower().Contains(lower))
                );
            }


            filtered = filtered.OrderBy(f => f.FaqId);

            IEnumerable<FAQsViewModel> vmEnumerable = filtered
                .Select(f => _mapper.Map<FAQsViewModel>(f));

            IPagedList<FAQsViewModel> pagedResult = vmEnumerable.ToPagedList(pageNumber, pageSize);

            return pagedResult;
        }


        public async Task<IPagedList<FAQ>> GetFAQsPagedAdminAsync(int pageNumber, int pageSize, string? searchTerm = null)
        {

            IEnumerable<FAQ> filtered = await _faqsRepository.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lower = searchTerm.Trim().ToLower();
                filtered = filtered.Where(f =>
                    (!string.IsNullOrEmpty(f.Question) && f.Question.ToLower().Contains(lower))
                    ||
                    (!string.IsNullOrEmpty(f.Answer) && f.Answer.ToLower().Contains(lower))
                );
            }

            filtered = filtered.OrderBy(f => f.FaqId);
            IPagedList<FAQ> pagedResult = filtered.ToPagedList(pageNumber, pageSize);
            return pagedResult;
        }


    }
}
