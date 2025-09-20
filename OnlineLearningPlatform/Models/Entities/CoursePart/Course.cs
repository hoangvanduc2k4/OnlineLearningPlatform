using OnlineLearningPlatform.Models.Entities.UserPart;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Models.Entities.CoursePart
{
    public class Course
    {
        [Key]
        public long CourseId { get; set; }

        [Required]
        [StringLength(255)]
        public string CourseName { get; set; } = null!;

        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Discount { get; set; }

        [Required]
        public string MentorId { get; set; }  = string.Empty;

        public string? AdminId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public DateTime? PublishedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [StringLength(50)]
        public string? StudyTime { get; set; }

        public long? LevelId { get; set; }

        [Required]
        public CourseStatus Status { get; set; } = CourseStatus.Draft;

        [ForeignKey("Creator")]
        public virtual User CreatorUser { get; set; } = null!;

        [ForeignKey("Acceptor")]
        public virtual User? AcceptorUser { get; set; }


        public virtual Level? Level { get; set; }
        public virtual ICollection<CourseImageUrl> CourseImageUrls { get; set; } = new List<CourseImageUrl>();
        public virtual ICollection<CourseCategory> CourseCategories { get; set; } = new List<CourseCategory>();
        public virtual ICollection<Module> Modules { get; set; } = new List<Module>();

    }
}
