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
            builder.HasData(GetWishlists().ToArray());
        }

        private static List<WishList> GetWishlists()
        {
            return new List<WishList>
            {
                new WishList
                {
                    CourseId = 1,
                    UserId = "3",
                    CreatedAt = new DateTime(2025, 3, 1)
                },
                new WishList
                {
                    CourseId = 2,
                    UserId = "4",
                    CreatedAt = new DateTime(2025, 3, 2)
                },
                new WishList
                {
                    CourseId = 3,
                    UserId = "5",
                    CreatedAt = new DateTime(2025, 3, 3)
                },
                new WishList
                {
                    CourseId = 4,
                    UserId = "6",
                    CreatedAt = new DateTime(2025, 3, 4)
                },
                new WishList
                {
                    CourseId = 5,
                    UserId = "3",
                    CreatedAt = new DateTime(2025, 3, 5)
                },
                new WishList
                {
                    CourseId = 2,
                    UserId = "5",
                    CreatedAt = new DateTime(2025, 3, 6)
                },
                new WishList
                {
                    CourseId = 1,
                    UserId = "6",
                    CreatedAt = new DateTime(2025, 3, 7)
                }
            };
        }
    }
}
