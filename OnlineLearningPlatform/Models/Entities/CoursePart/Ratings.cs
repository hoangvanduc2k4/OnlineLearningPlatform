using OnlineLearningPlatform.Models.Entities.UserPart;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.Entities.CoursePart
{
    public class Ratings : BaseEntity
    {
        [Key]
        public long RatingId { get; set; }

        [Required]
        public byte Rating { get; set; }

        public string? Feedback { get; set; }

        public long CourseId { get; set; }

        public string UserId { get; set; } = string.Empty;

        public virtual Course Course { get; set; } = null!;
        public virtual User User { get; set; } = null!;

    }
}
