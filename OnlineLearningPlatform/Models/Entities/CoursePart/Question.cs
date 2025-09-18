using Microsoft.CodeAnalysis.Options;
using OnlineLearningPlarform.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlarform.Models.Entities.CoursePart
{
    public class Question : BaseEntity
    {

        [Key]
        public long QuestionId { get; set; }

        [Required]
        public int QuestionNum { get; set; }

        public long QuizId { get; set; }

        [Required]
        [StringLength(255)]
        public string QuestionContent { get; set; } = null!;


        public virtual Quiz Quiz { get; set; } = null!;
        public virtual ICollection<Option> Options { get; set; } = new List<Option>();

    }
}
