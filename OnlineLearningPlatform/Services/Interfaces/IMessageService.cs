using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.ViewModels;
namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IMessageService
    {
        Task<Message> SendMessageAsync(string senderId, string receiverId, string content);
        Task<IEnumerable<Message>> GetMessagesBetweenUsersAsync(string senderId, string receiverId);
        Task<IEnumerable<ChatPartner>> GetChatPartnersAsync(string userId);
        Task MarkMessagesAsReadAsync(string senderId, string receiverId);
    }
}
