using System.ComponentModel.DataAnnotations;
using OnlineLearningPlarform.Models.Entities.UserPart;

namespace OnlineLearningPlarform.Models.Entities.CoursePart
{
    public class WishList
    {
        public long CourseId { get; set; }
        public string UserId { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual Course Course { get; set; } = null!;
        public virtual User User { get; set; } = null!;

    }
}
