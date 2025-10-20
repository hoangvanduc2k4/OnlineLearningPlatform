using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System;
using System.Collections.Generic;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class RatingSeedConfiguration : IEntityTypeConfiguration<Ratings>
    {
        public void Configure(EntityTypeBuilder<Ratings> builder)
        {
            builder.HasData(GetRatings().ToArray());
        }

        private static List<Ratings> GetRatings()
        {
            return new List<Ratings>
            {
                // === Các đánh giá chỉ từ User 5, 6, 7 ===

                // CourseId = 1
                new Ratings { RatingId = 1, Rating = 5, Feedback = "Great course, very helpful!", CourseId = 1, UserId = "5", DateCreated = new DateTime(2025, 3, 5) },
                new Ratings { RatingId = 2, Rating = 4, Feedback = "Good explanation, but can be improved.", CourseId = 1, UserId = "6", DateCreated = new DateTime(2025, 3, 6) },

                // CourseId = 2
                new Ratings { RatingId = 3, Rating = 5, Feedback = "Excellent content!", CourseId = 2, UserId = "7", DateCreated = new DateTime(2025, 3, 7) },
                new Ratings { RatingId = 4, Rating = 4, Feedback = "Really enjoyed this one.", CourseId = 2, UserId = "5", DateCreated = new DateTime(2025, 3, 8) },

                // CourseId = 3
                new Ratings { RatingId = 5, Rating = 4, Feedback = "Well structured and clear.", CourseId = 3, UserId = "6", DateCreated = new DateTime(2025, 3, 9) },
                new Ratings { RatingId = 6, Rating = 5, Feedback = "Loved the practical examples.", CourseId = 3, UserId = "7", DateCreated = new DateTime(2025, 3, 10) },

                // CourseId = 4
                new Ratings { RatingId = 7, Rating = 5, Feedback = "Outstanding course! Highly recommended.", CourseId = 4, UserId = "5", DateCreated = new DateTime(2025, 3, 11) },
                new Ratings { RatingId = 8, Rating = 4, Feedback = "Good for beginners.", CourseId = 4, UserId = "6", DateCreated = new DateTime(2025, 3, 12) },

                // CourseId = 5
                new Ratings { RatingId = 9, Rating = 5, Feedback = "A must-take course!", CourseId = 5, UserId = "7", DateCreated = new DateTime(2025, 3, 13) },
                new Ratings { RatingId = 10, Rating = 4, Feedback = "Enjoyed the teaching style.", CourseId = 5, UserId = "5", DateCreated = new DateTime(2025, 3, 14) },
            };
        }
    }
}
