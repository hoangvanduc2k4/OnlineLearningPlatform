using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.Entities.Others;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class ChatPartner
    {
        public User Partner { get; set; } = null!;
        public Message LatestMessage { get; set; } = null!;
        public int UnreadCount { get; set; }
    }
}
