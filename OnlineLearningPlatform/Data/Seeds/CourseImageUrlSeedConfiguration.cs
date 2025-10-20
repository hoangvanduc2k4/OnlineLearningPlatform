using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class CourseImageUrlSeedConfiguration : IEntityTypeConfiguration<CourseImageUrl>
    {
        public void Configure(EntityTypeBuilder<CourseImageUrl> builder)
        {
            builder.HasData(GetImages().ToArray());
        }

        private static CourseImageUrl[] GetImages()
        {
            var list = new List<CourseImageUrl>();
            long id = 1;


            int totalImages = 5;

            for (int course = 1; course <= 55; course++)
            {

                for (int imgIndex = 0; imgIndex < 3; imgIndex++)
                {
                    // Tính toán số thứ tự của ảnh (1 đến 5)
                    // imgIndex là 0, 1, 2. (imgIndex % totalImages) + 1 sẽ là 1, 2, 3
                    // Nếu bạn muốn dùng 3 ảnh đầu tiên (1.png, 2.png, 3.png) cho mỗi khóa học thì chỉ cần dùng (imgIndex + 1)
                    int imageNumber = (imgIndex % totalImages) + 1; // Sử dụng ảnh 1, 2, 3, 4, 5 luân phiên

                    // Nếu bạn chỉ muốn dùng 3 ảnh đầu (1, 2, 3) cho tất cả các khóa học
                    // int imageNumber = imgIndex + 1; // Sẽ là 1, 2, 3

                    list.Add(new CourseImageUrl
                    {
                        Id = id++,
                        CourseId = course,
                        Url = $"/img/Course/{imageNumber}.png"
                    });
                }
            }
            return list.ToArray();
        }
    }
}