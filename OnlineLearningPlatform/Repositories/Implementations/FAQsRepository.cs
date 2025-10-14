using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class FAQsRepository : BaseRepository<FAQ>, IFAQsRepository
    {
        public FAQsRepository(OnlineLearningDBContext context) : base(context) { }
    }

}
