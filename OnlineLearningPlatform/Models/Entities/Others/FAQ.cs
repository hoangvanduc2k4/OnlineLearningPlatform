using OnlineLearningPlarform.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlarform.Models.Entities.Others
{
    public class FAQ
    {

        [Key]
        public long FaqId { get; set; }
        [Required]
        public string Question { get; set; } = null!;
        [Required]
        public string Answer { get; set; } = null!;
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public CommonStatus CommonStatus { get; set; } = CommonStatus.Showed;

    }
}
