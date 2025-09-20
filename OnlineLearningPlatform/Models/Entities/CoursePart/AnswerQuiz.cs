using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.UserPart;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.Entities.CoursePart
{
    public class AnswerQuiz : BaseEntity
    {
        [Key]
        public long AnswerQuizId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public long QuestionId { get; set; }

        public long? OptionId { get; set; }

        [Required]
        public bool IsCorrect { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Question Question { get; set; } = null!;

    }
}
