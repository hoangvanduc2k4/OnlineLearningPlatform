using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.Entities.CoursePart
{
    public class CourseImageUrl
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Url { get; set; } = null!;

        public long CourseId { get; set; }

        public virtual Course Course { get; set; } = null!;

    }
}
