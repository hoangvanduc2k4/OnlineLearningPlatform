using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.CoursePart; // Đảm bảo namespace này chính xác

namespace OnlineLearningPlatform.Data.Seeds
{
    public class CourseEnrollmentSeedConfiguration : IEntityTypeConfiguration<CourseEnrollment>
    {
        public void Configure(EntityTypeBuilder<CourseEnrollment> builder)
        {
            // Giữ lại định nghĩa composite key, rất quan trọng
            builder.HasKey(e => new { e.CourseId, e.UserId });

            builder.HasData(GetEnrollments().ToArray());
        }

        private static List<CourseEnrollment> GetEnrollments()
        {
            var enrollments = new List<CourseEnrollment>();
            var random = new Random();

            // ===== CÁC THAM SỐ CẤU HÌNH =====
            var userIds = new List<string> { "5", "6", "7" };
            const int totalCourses = 55;
            const int enrollmentsPerUser = 15; // Mỗi user sẽ được ghi danh vào 15 khóa học

            // ===== LOGIC TẠO DỮ LIỆU TỰ ĐỘNG =====
            foreach (var userId in userIds)
            {
                // Sử dụng HashSet để đảm bảo mỗi user không ghi danh vào cùng 1 khóa học 2 lần
                var enrolledCourseIds = new HashSet<int>();

                for (int i = 0; i < enrollmentsPerUser; i++)
                {
                    int courseId;
                    // Lặp lại việc chọn ngẫu nhiên cho đến khi tìm được khóa học mà user chưa ghi danh
                    do
                    {
                        courseId = random.Next(1, totalCourses + 1);
                    } while (enrolledCourseIds.Contains(courseId));

                    // Thêm khóa học vừa chọn vào danh sách đã ghi danh
                    enrolledCourseIds.Add(courseId);

                    enrollments.Add(new CourseEnrollment
                    {
                        UserId = userId,
                        CourseId = courseId,
                        // Thêm một chút ngẫu nhiên vào ngày ghi danh
                        DateCreated = new DateTime(2025, 3, 1).AddDays(random.Next(0, 30))
                    });
                }
            }

            return enrollments;
        }
    }
}