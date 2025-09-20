using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(GetRoles().ToArray());
        }

        private static List<IdentityRole> GetRoles()
        {
            return new List<IdentityRole>
            {
                new IdentityRole { Id = "admin-role", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "mentor-role", Name = "Mentor", NormalizedName = "MENTOR" },
                new IdentityRole { Id = "student-role", Name = "Student", NormalizedName = "STUDENT" }
            };
        }
    }
}
