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
            for (int course = 1; course <= 12; course++)
            {
                for (int img = 1; img <= 3; img++)
                {
                    list.Add(new CourseImageUrl
                    {
                        Id = id++,
                        CourseId = course,
                        Url = $"https://picsum.photos/seed/course{course}_img{img}/600/400"
                    });
                }
            }
            return list.ToArray();
        }

    }
}
