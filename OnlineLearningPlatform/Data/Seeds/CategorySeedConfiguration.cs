using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System.Collections.Generic;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GetCategories().ToArray());
        }

        private static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Programming", IsDeleted = false },
                new Category { CategoryId = 2, CategoryName = "Design",      IsDeleted = false },
                new Category { CategoryId = 3, CategoryName = "Marketing",   IsDeleted = false },
                new Category { CategoryId = 4, CategoryName = "Business",    IsDeleted = false },
                new Category { CategoryId = 5, CategoryName = "Photography", IsDeleted = false }
            };
        }
    }
}
