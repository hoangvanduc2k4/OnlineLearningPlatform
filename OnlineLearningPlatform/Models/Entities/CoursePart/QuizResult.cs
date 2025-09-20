using OnlineLearningPlatform.Models.Entities.UserPart;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.Entities.CoursePart
{
    public class QuizResult
    {
        [Key]
        public long QuizResultId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public long QuizId { get; set; }

        [Column(TypeName = "decimal(5,2)"), Required]
        public decimal Score { get; set; }
        [Required]
        public int TotalQuestions { get; set; }
        [Required]
        public int CorrectAnswers { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;

        public virtual User User { get; set; } = null!;
        public virtual Quiz Quiz { get; set; } = null!;

    }
}
