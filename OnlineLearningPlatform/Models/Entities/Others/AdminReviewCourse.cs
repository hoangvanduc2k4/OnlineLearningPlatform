using OnlineLearningPlarform.Enums;
using OnlineLearningPlarform.Models.Entities.CoursePart;
using OnlineLearningPlarform.Models.Entities.UserPart;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlarform.Models.Entities.Others
{
    public class AdminReviewCourse
    {
        [Key]
        public long ReviewId { get; set; }

        public long CourseId { get; set; }

        public string AdminId { get; set; } = string.Empty;

        [Required]
        public ReviewStatus Status { get; set; }

        public string? ReviewNotes { get; set; }

        [Required]
        public DateTime ReviewedAt { get; set; } = DateTime.Now;

        public virtual Course Course { get; set; } = null!;
        public virtual User Admin { get; set; } = null!;

    }
}
