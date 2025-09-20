using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.Entities.CoursePart
{
    public class Quiz : BaseEntity
    {
        [Key]
        public long QuizId { get; set; }

        public long ModuleId { get; set; }

        [Required]
        [StringLength(255)]
        public string QuizName { get; set; } = null!;

        public int? QuizTime { get; set; }

        public int? PassScore { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public virtual Module Module { get; set; } = null!;
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    }
}
