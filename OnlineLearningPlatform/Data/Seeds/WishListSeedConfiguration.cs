using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System;
using System.Collections.Generic;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class WishListSeedConfiguration : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            // Bảng này thường có khóa chính kết hợp (composite key)
            // Nếu chưa định nghĩa ở file khác, bạn có thể thêm ở đây:
            builder.HasKey(w => new { w.UserId, w.CourseId });

            builder.HasData(GetWishlists().ToArray());
        }

        private static List<WishList> GetWishlists()
        {
            var wishlists = new List<WishList>();
            var random = new Random();

            // ===== CÁC THAM SỐ CẤU HÌNH =====
            var userIds = new List<string> { "5", "6", "7" };
            const int totalCourses = 55;
            const int coursesPerUser = 7;

            // ===== LOGIC TẠO DỮ LIỆU TỰ ĐỘNG =====
            foreach (var userId in userIds)
            {
                // Dùng HashSet để đảm bảo mỗi user không có khóa học trùng lặp trong wishlist
                var addedCourseIds = new HashSet<int>();

                for (int i = 0; i < coursesPerUser; i++)
                {
                    int courseId;
                    // Chọn ngẫu nhiên một CourseId cho đến khi tìm được một khóa học chưa có trong list
                    do
                    {
                        courseId = random.Next(1, totalCourses + 1);
                    } while (addedCourseIds.Contains(courseId));

                    // Thêm khóa học vừa chọn vào danh sách đã có để kiểm tra trùng lặp
                    addedCourseIds.Add(courseId);

                    wishlists.Add(new WishList
                    {
                        UserId = userId,
                        CourseId = courseId,
                        // Thêm một chút ngẫu nhiên vào ngày tạo để dữ liệu đa dạng hơn
                        CreatedAt = new DateTime(2025, 3, 1).AddDays(random.Next(0, 60))
                    });
                }
            }

            return wishlists;
        }
    }
}