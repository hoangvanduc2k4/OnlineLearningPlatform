using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Utils;


namespace OnlineLearningPlatform.Data.Seeds
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var users = new List<User>
            {
                // --- Admin ---
                new User
                {
                    Id = "1",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    EmailConfirmed = true,
                    FullName = "System Admin",
                    Dob = new DateOnly(2003, 7, 6),
                    Phone = "0000000000",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/1/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = PasswordUtils.HashPassword("123456")
                },

                // --- Mentor demo ---
                new User
                {
                    Id = "2",
                    UserName = "mentor@demo.com",
                    NormalizedUserName = "MENTOR@DEMO.COM",
                    Email = "mentor@demo.com",
                    NormalizedEmail = "MENTOR@DEMO.COM",
                    EmailConfirmed = true,
                    FullName = "Demo Mentor",
                    Dob = new DateOnly(1990, 1, 1),
                    Phone = "0000000001",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/2/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = PasswordUtils.HashPassword("123456")
                },

                // --- 3 mentee cố định ---
                new User
                {
                    Id = "3",
                    UserName = "mentee1@example.com",
                    NormalizedUserName = "MENTEE1@EXAMPLE.COM",
                    Email = "mentee1@example.com",
                    NormalizedEmail = "MENTEE1@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "Mentee One",
                    Dob = new DateOnly(1998, 3, 3),
                    Phone = "0900000003",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/mentee1/200/200",
                    CreatedAt = new DateTime(2025, 1, 2),
                    PasswordHash = PasswordUtils.HashPassword("123456")
                },
                new User
                {
                    Id = "4",
                    UserName = "mentee2@example.com",
                    NormalizedUserName = "MENTEE2@EXAMPLE.COM",
                    Email = "mentee2@example.com",
                    NormalizedEmail = "MENTEE2@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "Mentee Two",
                    Dob = new DateOnly(1997, 4, 4),
                    Phone = "0900000004",
                    Gender = false,
                    AvatarUrl = "https://picsum.photos/seed/mentee2/200/200",
                    CreatedAt = new DateTime(2025, 1, 2),
                    PasswordHash = PasswordUtils.HashPassword("123456")
                },
                new User
                {
                    Id = "5",
                    UserName = "mentee3@example.com",
                    NormalizedUserName = "MENTEE3@EXAMPLE.COM",
                    Email = "mentee3@example.com",
                    NormalizedEmail = "MENTEE3@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "Mentee Three",
                    Dob = new DateOnly(1996, 5, 5),
                    Phone = "0900000005",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/mentee3/200/200",
                    CreatedAt = new DateTime(2025, 1, 2),
                    PasswordHash = PasswordUtils.HashPassword("123456")
                }
            };

            // --- Vòng for thêm nhiều user Mentee tự động ---
            // Id từ 6 -> 15 (có thể thay số lượng tuỳ ý)
            for (int i = 6; i <= 50; i++)
            {
                users.Add(new User
                {
                    Id = i.ToString(),
                    UserName = $"user{i}@example.com",
                    NormalizedUserName = $"USER{i}@EXAMPLE.COM",
                    Email = $"user{i}@example.com",
                    NormalizedEmail = $"USER{i}@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = $"User {i}",
                    Dob = new DateOnly(2000, 1, 1).AddYears(-i), // năm sinh lùi theo i cho khác nhau
                    Phone = $"09000000{i:D2}",
                    Gender = i % 2 == 0, // xen kẽ nam/nữ
                    AvatarUrl = $"https://picsum.photos/seed/{i}/200/200",
                    CreatedAt = new DateTime(2025, 1, 3),
                    PasswordHash = PasswordUtils.HashPassword("123456")
                });
            }

            builder.HasData(users);
        }



    }
}
