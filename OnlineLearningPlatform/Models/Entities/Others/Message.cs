using System.ComponentModel.DataAnnotations;
using OnlineLearningPlatform.Models.Entities.UserPart;

namespace OnlineLearningPlatform.Models.Entities.Others
{
    public class Message
    {
        [Key]
        public long MessageId { get; set; }
        public string SenderId { get; set; } = string.Empty;
        public string ReceiverId { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = false;

        public virtual User Sender { get; set; } = null!;
        public virtual User Receiver { get; set; } = null!;

    }
}
