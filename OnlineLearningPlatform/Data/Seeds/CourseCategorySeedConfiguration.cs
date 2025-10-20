using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System;
using System.Collections.Generic;
using System.Linq; // Cần thêm using này cho HashSet

namespace OnlineLearningPlatform.Data.Seeds
{
    public class CourseCategorySeedConfiguration : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            // Cần định nghĩa khóa chính phức hợp cho bảng join
            builder.HasKey(cc => new { cc.CourseId, cc.CategoryId });

            builder.HasData(GetCourseCategories().ToArray());
        }

        private static List<CourseCategory> GetCourseCategories()
        {
            var list = new List<CourseCategory>();
            var random = new Random();
            int totalCourses = 55;
            int totalCategories = 10;

            for (long courseId = 1; courseId <= totalCourses; courseId++)
            {
                // Sử dụng HashSet để đảm bảo không gán trùng category cho cùng một khóa học
                var assignedCategories = new HashSet<int>();

                // 1. Quyết định số lượng category sẽ gán cho khóa học này (từ 1 đến 3)
                int numberOfCategoriesToAssign = random.Next(1, 4); // Sẽ trả về 1, 2, hoặc 3

                // 2. Lặp để lấy đủ số lượng category cần gán
                for (int i = 0; i < numberOfCategoriesToAssign; i++)
                {
                    int randomCategoryId;
                    // Vòng lặp do-while đảm bảo chúng ta lấy được một categoryId chưa được gán
                    do
                    {
                        randomCategoryId = random.Next(1, totalCategories + 1); // Lấy ngẫu nhiên từ 1 đến 55
                    } while (!assignedCategories.Add(randomCategoryId)); // Nếu Add trả về false (đã tồn tại), lặp lại
                }

                // 3. Thêm các cặp CourseId - CategoryId đã chọn vào danh sách chính
                foreach (var categoryId in assignedCategories)
                {
                    list.Add(new CourseCategory { CourseId = courseId, CategoryId = categoryId });
                }
            }
            return list;
        }
    }
}