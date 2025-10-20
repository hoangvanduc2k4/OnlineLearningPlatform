using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class CourseSeedConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(GetCourses());
        }

        private static List<Course> GetCourses()
        {
            var courses = new List<Course>();
            var random = new Random();

            for (long i = 1; i <= 55; i++)
            {
                // Tạo số giờ ngẫu nhiên
                int hours = random.Next(3, 31);
                string studyTimeString = $"{hours} hours";

                // Tạo MentorId ngẫu nhiên từ 2, 3, hoặc 4
                string randomMentorId = random.Next(2, 5).ToString(); // random.Next(min, max) -> min <= result < max

                courses.Add(new Course
                {
                    CourseId = i,
                    CourseName = $"Demo Course {i}",
                    Description = $"A detailed description for course number {i}. Learn the fundamentals and advanced concepts.",
                    Price = 20 + i,
                    Discount = (i % 3 == 0) ? 5m : 0m,

                    // Gán MentorId ngẫu nhiên
                    MentorId = randomMentorId,
                    AdminId = "1",
                    CreatedAt = new DateTime(2025, 1, 1),
                    UpdatedAt = new DateTime(2025, 1, 5),
                    PublishedAt = new DateTime(2025, 2, 1),
                    StudyTime = studyTimeString,
                    LevelId = (i % 3) + 1,
                    Status = CourseStatus.Approved
                });
            }

            return courses;
        }
    }
}