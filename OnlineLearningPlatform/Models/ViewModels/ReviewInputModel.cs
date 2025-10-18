using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.Entities.Others
{
    public class ReviewInputModel
    {
        [Display(Name = "Review Notes (optional, but required if rejecting)")]
        public string? ReviewNotes { get; set; }
    }
}
