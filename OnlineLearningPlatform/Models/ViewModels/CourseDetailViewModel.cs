namespace OnlineLearningPlatform.Models.ViewModels
{
    public class CourseDetailsViewModel
    {
        public long CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int? Discount { get; set; }
        public string? StudyTime { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? ImageUrl { get; set; }

        // Thông tin Mentor
        public string? MentorId { get; set; }
        public string? MentorName { get; set; }
        public string? MentorAvatarUrl { get; set; }

        // Thông tin Level và Category
        public string? LevelName { get; set; }
        public List<string> CategoryNames { get; set; } = new List<string>();

        // Thống kê Rating
        public double AverageRating { get; set; }
        public int FeedbackCount { get; set; }
        public int TotalQuizCount { get; set; }

        public bool IsInWishlist { get; set; }

        public bool IsEnrolled { get; set; }

        // Chi tiết nội dung khóa học
        public List<ModuleViewModel> Modules { get; set; } = new List<ModuleViewModel>();

        // Danh sách đánh giá
        public List<RatingViewModel> Ratings { get; set; } = new List<RatingViewModel>();

    }

    public class ModuleViewModel
    {
        public long ModuleId { get; set; }
        public string ModuleName { get; set; } = string.Empty;
        public int ModuleNumber { get; set; }
        public List<LessonViewModel> Lessons { get; set; } = new List<LessonViewModel>();
        public List<QuizViewModel> Quizzes { get; set; } = new List<QuizViewModel>();
    }

    public class LessonViewModel
    {
        public long LessonId { get; set; }
        public string LessonName { get; set; } = string.Empty;
        public int LessonNumber { get; set; }
        public string? LessonContent { get; set; }
        public string? LessonVideo { get; set; }
        public int? Duration { get; set; }
    }

    public class RatingViewModel
    {
        public string? UserName { get; set; }
        public string? UserAvatarUrl { get; set; }
        public byte RatingValue { get; set; }
        public string? Feedback { get; set; }
        public DateTime FeedbackDate { get; set; }
    }
}