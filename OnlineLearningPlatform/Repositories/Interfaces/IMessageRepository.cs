    using OnlineLearningPlatform.Models.Entities.Others;
namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IMessageRepository
    {
        Task<Message> AddMessageAsync(Message message);
        Task<IEnumerable<Message>> GetMessagesBetweenUsersAsync(string senderId, string receiverId);
        Task<IEnumerable<Message>> GetLatestMessagesForUserAsync(string userId);
        Task MarkMessagesAsReadAsync(string senderId, string receiverId);
        Task<int> CountUnreadMessagesAsync(string senderId, string receiverId);
    }
}
