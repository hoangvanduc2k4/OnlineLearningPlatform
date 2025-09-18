using OnlineLearningPlarform.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlarform.Models.Entities.CoursePart
{
    public class Lesson : BaseEntity
    {
        [Key]
        public long LessonId { get; set; }

        public long ModuleId { get; set; }

        [Required]
        public int LessonNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string LessonName { get; set; } = null!;

        public string? LessonContent { get; set; }

        public string? LessonVideo { get; set; }

        public int? Duration { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        [Required]
        public CommonStatus Status { get; set; }

        public virtual Module Module { get; set; } = null!;

    }
}
