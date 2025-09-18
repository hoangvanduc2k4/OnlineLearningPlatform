using OnlineLearningPlarform.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlarform.Models.Entities.CoursePart
{
    public class Option : BaseEntity
    {

        [Key]
        public long OptionId { get; set; }

        public long QuestionId { get; set; }

        [Required]
        [StringLength(255)]
        public string OptionText { get; set; } = null!;

        [Required]
        public bool IsCorrect { get; set; }

        [Required]
        public CommonStatus Status { get; set; }

        public virtual Question Question { get; set; } = null!;

    }
}
