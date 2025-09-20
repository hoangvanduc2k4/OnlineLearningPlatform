using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.CoursePart;

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
            var list = new List<Ratings>
            {
                new Ratings { RatingId = 1, Rating = 5, Feedback = "Great course, very helpful!", CourseId = 1, UserId = "3", DateCreated = new DateTime(2025, 3, 5) },
                new Ratings { RatingId = 2, Rating = 4, Feedback = "Good explanation but can be improved.", CourseId = 1, UserId = "4", DateCreated = new DateTime(2025, 3, 6) },

                new Ratings { RatingId = 3, Rating = 5, Feedback = "Excellent content!", CourseId = 2, UserId = "5", DateCreated = new DateTime(2025, 3, 5) },
                new Ratings { RatingId = 4, Rating = 3, Feedback = "Average, expected more details.", CourseId = 2, UserId = "6", DateCreated = new DateTime(2025, 3, 6) },

                new Ratings { RatingId = 5, Rating = 4, Feedback = "Well structured and clear.", CourseId = 3, UserId = "7", DateCreated = new DateTime(2025, 3, 7) },
                new Ratings { RatingId = 6, Rating = 5, Feedback = "Loved the practical examples.", CourseId = 3, UserId = "8", DateCreated = new DateTime(2025, 3, 8) },

                new Ratings { RatingId = 7, Rating = 2, Feedback = "Too basic for me.", CourseId = 4, UserId = "9", DateCreated = new DateTime(2025, 3, 9) },
                new Ratings { RatingId = 8, Rating = 4, Feedback = "Good for beginners.", CourseId = 4, UserId = "10", DateCreated = new DateTime(2025, 3, 10) },

                new Ratings { RatingId = 9, Rating = 5, Feedback = "Outstanding course!", CourseId = 5, UserId = "11", DateCreated = new DateTime(2025, 3, 11) },
                new Ratings { RatingId = 10, Rating = 4, Feedback = "Enjoyed the teaching style.", CourseId = 5, UserId = "12", DateCreated = new DateTime(2025, 3, 12) },
            };

            return list;
        }
    }
}
