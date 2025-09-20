using OnlineLearningPlatform.Models.Entities.UserPart;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Models.Entities.Others
{
    [Table("MentorApplications")]
    public class MentorApplication
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = string.Empty;
        public virtual User User { get; set; } = null!;

        [Required]
        [StringLength(2000)]
        public string CvUrl { get; set; } = string.Empty;

        [StringLength(4000)]
        public string? Note { get; set; }

        public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ReviewedAt { get; set; }

        [ForeignKey(nameof(AdminReviewer))]
        public string? AdminReviewerId { get; set; }
        public virtual User? AdminReviewer { get; set; }
    }
}
