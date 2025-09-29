using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(OnlineLearningDBContext context) : base(context)
        {
        }

    }
}
