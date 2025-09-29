using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineLearningPlatform.Data.Seeds
{
    /// <summary>
    /// Gán quyền cho các user đã seed sẵn.
    /// </summary>
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            // danh sách các UserRole cần seed
            var userRoles = new List<IdentityUserRole<string>>
            {
                // --- Admin ---
                new IdentityUserRole<string>
                {
                    UserId = "1",          // Id của admin trong UserSeedConfiguration
                    RoleId = "admin-role"  // Id của role Admin trong RoleSeedConfiguration
                },

                // --- Mentor demo ---
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "mentor-role"
                }
            };

            // Gán Mentee cho tất cả user còn lại (Id 3-12)
            for (int i = 3; i <= 50; i++)
            {
                userRoles.Add(new IdentityUserRole<string>
                {
                    UserId = i.ToString(),
                    RoleId = "mentee-role"
                });
            }

            builder.HasData(userRoles);
        }
    }
}
