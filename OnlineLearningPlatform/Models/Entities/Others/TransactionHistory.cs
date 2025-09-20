using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.UserPart;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Models.Entities.Others
{
    public class TransactionHistory : BaseEntity
    {
        [Key]
        public long TransactionId { get; set; }

        public string UserId { get; set; } = string.Empty;

        public long? CourseId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        public TransactionStatus Status { get; set; }  // ✅ dùng enum của bạn

        [StringLength(255)]
        public string? Description { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Course? Course { get; set; }
    }
}
