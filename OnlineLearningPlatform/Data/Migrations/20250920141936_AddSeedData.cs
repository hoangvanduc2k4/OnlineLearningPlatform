using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "IsDeleted" },
                values: new object[,]
                {
                    { 1L, "Programming", false },
                    { 2L, "Design", false },
                    { 3L, "Marketing", false },
                    { 4L, "Business", false },
                    { 5L, "Photography", false }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FaqId", "Answer", "CommonStatus", "CreatedAt", "Question", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "Bạn có thể nhấn vào nút Đăng ký trên trang chủ và điền đầy đủ thông tin yêu cầu.", 0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Làm thế nào để đăng ký tài khoản?", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "Một số khóa học được cung cấp miễn phí, bạn có thể tìm trong danh mục 'Khóa học miễn phí'.", 0, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tôi có thể học các khóa học miễn phí không?", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "Chúng tôi hỗ trợ thanh toán qua thẻ ngân hàng, ví điện tử và PayPal.", 0, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phương thức thanh toán nào được hỗ trợ?", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, "Bạn có thể nộp đơn ứng tuyển Mentor trong mục 'Trở thành giảng viên'.", 0, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Làm thế nào để trở thành giảng viên?", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "Có, nền tảng hỗ trợ cả trên web và ứng dụng di động.", 0, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tôi có thể học trên điện thoại không?", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "LevelId", "IsDeleted", "LevelName" },
                values: new object[,]
                {
                    { 1L, false, "Beginner" },
                    { 2L, false, "Intermediate" },
                    { 3L, false, "Advanced" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin-role", null, "Admin", "ADMIN" },
                    { "mentor-role", null, "Mentor", "MENTOR" },
                    { "student-role", null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Dob", "Email", "EmailConfirmed", "FullName", "Gender", "IsActived", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "https://picsum.photos/seed/1/200/200", "24ff7179-5472-49bd-98c7-4ea305c6fc61", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 7, 6), "admin@admin.com", true, "System Admin", true, true, false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000000", null, false, "963bc9e4-95b5-4281-9cfe-5cdf9cc1d237", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(888), "admin@admin.com" },
                    { "10", 0, "https://picsum.photos/seed/10/200/200", "c73466ec-a15d-4e17-b077-0c77857c5147", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1999, 9, 9), "user10@example.com", true, "User Ten", false, true, false, false, null, "USER10@EXAMPLE.COM", "USER10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000010", null, false, "426d52fa-909c-4a8e-9326-c9583fd065c8", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1182), "user10@example.com" },
                    { "11", 0, "https://picsum.photos/seed/11/200/200", "bae8d433-401e-4562-8616-4cb8d36fa8a5", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1991, 1, 11), "user11@example.com", true, "User Eleven", true, true, false, false, null, "USER11@EXAMPLE.COM", "USER11@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000011", null, false, "41089673-5515-440f-83b5-3c70626489b2", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1206), "user11@example.com" },
                    { "12", 0, "https://picsum.photos/seed/12/200/200", "65723c00-4c0a-4d76-a38d-8d38aee68971", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1992, 2, 12), "user12@example.com", true, "User Twelve", false, true, false, false, null, "USER12@EXAMPLE.COM", "USER12@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000012", null, false, "2fa8adca-eeac-4625-8e1e-d87eb01fe991", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1227), "user12@example.com" },
                    { "2", 0, "https://picsum.photos/seed/2/200/200", "09f69620-924b-4d56-9be8-d7a0aeee6186", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1990, 1, 1), "mentor@demo.com", true, "Demo Mentor", true, true, false, false, null, "MENTOR@DEMO.COM", "MENTOR@DEMO.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000001", null, false, "a92802c6-c5c3-41e0-a860-cfeb7c7232d5", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(940), "mentor@demo.com" },
                    { "3", 0, "https://picsum.photos/seed/3/200/200", "6e2d10b1-b5bb-4ede-bd03-4fe62f377d61", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1995, 5, 5), "user3@example.com", true, "User Three", true, true, false, false, null, "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000003", null, false, "216a9f2b-5225-4be0-9f7d-3f465f814916", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(974), "user3@example.com" },
                    { "4", 0, "https://picsum.photos/seed/4/200/200", "530c8eaa-f6d4-4182-b868-43bc6ac3a1e7", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1992, 2, 2), "user4@example.com", true, "User Four", false, true, false, false, null, "USER4@EXAMPLE.COM", "USER4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000004", null, false, "61422693-d5e8-4702-b633-87b6b1ebc7fd", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1048), "user4@example.com" },
                    { "5", 0, "https://picsum.photos/seed/5/200/200", "afc770bc-c4de-4fbe-8f95-8e2c274a8b9f", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1993, 3, 3), "user5@example.com", true, "User Five", true, true, false, false, null, "USER5@EXAMPLE.COM", "USER5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000005", null, false, "842f0b88-6c52-4562-a50c-b908d48c614d", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1070), "user5@example.com" },
                    { "6", 0, "https://picsum.photos/seed/6/200/200", "ce7d2998-dccb-4c32-ace4-b6366cd31b51", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1994, 4, 4), "user6@example.com", true, "User Six", false, true, false, false, null, "USER6@EXAMPLE.COM", "USER6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000006", null, false, "e9ff54a5-9b09-4baa-95b6-0b1d8317a08b", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1095), "user6@example.com" },
                    { "7", 0, "https://picsum.photos/seed/7/200/200", "81da1e18-3bac-4344-acf4-45e63bb5e5be", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1996, 6, 6), "user7@example.com", true, "User Seven", true, true, false, false, null, "USER7@EXAMPLE.COM", "USER7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000007", null, false, "9b7ea821-ed79-4011-be1b-1fb603620794", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1116), "user7@example.com" },
                    { "8", 0, "https://picsum.photos/seed/8/200/200", "65eaeb26-fdf5-4d0f-9734-51360edb06ea", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1997, 7, 7), "user8@example.com", true, "User Eight", false, true, false, false, null, "USER8@EXAMPLE.COM", "USER8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000008", null, false, "a004c34e-f553-4e16-b5c8-7f863082a9a7", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1141), "user8@example.com" },
                    { "9", 0, "https://picsum.photos/seed/9/200/200", "86a3e24a-b700-4ac2-8c9f-b3df3db9713c", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1998, 8, 8), "user9@example.com", true, "User Nine", true, true, false, false, null, "USER9@EXAMPLE.COM", "USER9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000009", null, false, "6cf7b012-0826-40c2-9bb6-ff9960dbc8f6", false, new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1162), "user9@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Acceptor", "AdminId", "CourseName", "CreatedAt", "Creator", "DeletedAt", "Description", "Discount", "LevelId", "MentorId", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, "1", "Demo Course 1", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 1", 0m, 2L, "2", 21m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, null, "1", "Demo Course 2", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 2", 0m, 3L, "2", 22m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, null, "1", "Demo Course 3", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 3", 5m, 1L, "2", 23m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, null, "1", "Demo Course 4", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 4", 0m, 2L, "2", 24m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, null, "1", "Demo Course 5", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 5", 0m, 3L, "2", 25m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, null, "1", "Demo Course 6", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 6", 5m, 1L, "2", 26m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, null, "1", "Demo Course 7", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 7", 0m, 2L, "2", 27m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, null, "1", "Demo Course 8", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 8", 0m, 3L, "2", 28m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, null, "1", "Demo Course 9", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 9", 5m, 1L, "2", 29m, null, 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, null, "1", "Demo Course 10", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 10", 0m, 2L, "2", 30m, null, 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, null, "1", "Demo Course 11", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 11", 0m, 3L, "2", 31m, null, 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12L, null, "1", "Demo Course 12", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mô t? ng?n g?n cho khoá h?c s? 12", 5m, 1L, "2", 32m, null, 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MentorApplications",
                columns: new[] { "Id", "AdminReviewerId", "CvUrl", "Note", "ReviewedAt", "Status", "SubmittedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, "1", "https://example.com/cv/3.pdf", "Experienced developer", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 2L, null, "https://example.com/cv/4.pdf", "UI/UX designer", null, 1, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 3L, "2", "https://example.com/cv/5.pdf", "Data analyst background", new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Content", "CreatedAt", "IsRead", "ReceiverId", "SenderId" },
                values: new object[,]
                {
                    { 1L, "Chào mừng bạn đến với hệ thống học trực tuyến!", new DateTime(2025, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "3", "1" },
                    { 2L, "Cảm ơn admin, mình rất hào hứng!", new DateTime(2025, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), true, "1", "3" },
                    { 3L, "Bạn có muốn tham gia nhóm học chung không?", new DateTime(2025, 2, 2, 15, 20, 0, 0, DateTimeKind.Unspecified), false, "5", "4" },
                    { 4L, "Ok, mình rất quan tâm.", new DateTime(2025, 2, 2, 15, 25, 0, 0, DateTimeKind.Unspecified), false, "4", "5" },
                    { 5L, "Chúng tôi đã nhận được đơn ứng tuyển mentor của bạn.", new DateTime(2025, 2, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "6", "2" }
                });

            migrationBuilder.InsertData(
                table: "AdminReviewCourses",
                columns: new[] { "ReviewId", "AdminId", "CourseId", "ReviewNotes", "ReviewedAt", "Status" },
                values: new object[,]
                {
                    { 1L, "1", 1L, "Approved for publishing", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2L, "1", 2L, "Needs improvement before publishing", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3L, "1", 3L, "Approved for publishing", new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4L, "1", 4L, "Needs improvement before publishing", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5L, "1", 5L, "Approved for publishing", new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6L, "1", 6L, "Needs improvement before publishing", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7L, "1", 7L, "Approved for publishing", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8L, "1", 8L, "Needs improvement before publishing", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9L, "1", 9L, "Approved for publishing", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10L, "1", 10L, "Needs improvement before publishing", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11L, "1", 11L, "Approved for publishing", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12L, "1", 12L, "Needs improvement before publishing", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "CourseCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 1L, 2L },
                    { 1L, 3L },
                    { 1L, 5L },
                    { 1L, 6L },
                    { 1L, 8L },
                    { 1L, 9L },
                    { 1L, 11L },
                    { 1L, 12L },
                    { 2L, 1L },
                    { 2L, 3L },
                    { 2L, 4L },
                    { 2L, 6L },
                    { 2L, 7L },
                    { 2L, 9L },
                    { 2L, 10L },
                    { 2L, 12L },
                    { 3L, 1L },
                    { 3L, 2L },
                    { 3L, 4L },
                    { 3L, 5L },
                    { 3L, 7L },
                    { 3L, 8L },
                    { 3L, 10L },
                    { 3L, 11L }
                });

            migrationBuilder.InsertData(
                table: "CourseEnrollments",
                columns: new[] { "CourseId", "UserId", "DateCreated", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, "3", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2L, "4", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3L, "5", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4L, "6", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, "7", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6L, "8", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "CourseImageUrls",
                columns: new[] { "Id", "CourseId", "Url" },
                values: new object[,]
                {
                    { 1L, 1L, "https://picsum.photos/seed/course1_img1/600/400" },
                    { 2L, 1L, "https://picsum.photos/seed/course1_img2/600/400" },
                    { 3L, 1L, "https://picsum.photos/seed/course1_img3/600/400" },
                    { 4L, 2L, "https://picsum.photos/seed/course2_img1/600/400" },
                    { 5L, 2L, "https://picsum.photos/seed/course2_img2/600/400" },
                    { 6L, 2L, "https://picsum.photos/seed/course2_img3/600/400" },
                    { 7L, 3L, "https://picsum.photos/seed/course3_img1/600/400" },
                    { 8L, 3L, "https://picsum.photos/seed/course3_img2/600/400" },
                    { 9L, 3L, "https://picsum.photos/seed/course3_img3/600/400" },
                    { 10L, 4L, "https://picsum.photos/seed/course4_img1/600/400" },
                    { 11L, 4L, "https://picsum.photos/seed/course4_img2/600/400" },
                    { 12L, 4L, "https://picsum.photos/seed/course4_img3/600/400" },
                    { 13L, 5L, "https://picsum.photos/seed/course5_img1/600/400" },
                    { 14L, 5L, "https://picsum.photos/seed/course5_img2/600/400" },
                    { 15L, 5L, "https://picsum.photos/seed/course5_img3/600/400" },
                    { 16L, 6L, "https://picsum.photos/seed/course6_img1/600/400" },
                    { 17L, 6L, "https://picsum.photos/seed/course6_img2/600/400" },
                    { 18L, 6L, "https://picsum.photos/seed/course6_img3/600/400" },
                    { 19L, 7L, "https://picsum.photos/seed/course7_img1/600/400" },
                    { 20L, 7L, "https://picsum.photos/seed/course7_img2/600/400" },
                    { 21L, 7L, "https://picsum.photos/seed/course7_img3/600/400" },
                    { 22L, 8L, "https://picsum.photos/seed/course8_img1/600/400" },
                    { 23L, 8L, "https://picsum.photos/seed/course8_img2/600/400" },
                    { 24L, 8L, "https://picsum.photos/seed/course8_img3/600/400" },
                    { 25L, 9L, "https://picsum.photos/seed/course9_img1/600/400" },
                    { 26L, 9L, "https://picsum.photos/seed/course9_img2/600/400" },
                    { 27L, 9L, "https://picsum.photos/seed/course9_img3/600/400" },
                    { 28L, 10L, "https://picsum.photos/seed/course10_img1/600/400" },
                    { 29L, 10L, "https://picsum.photos/seed/course10_img2/600/400" },
                    { 30L, 10L, "https://picsum.photos/seed/course10_img3/600/400" },
                    { 31L, 11L, "https://picsum.photos/seed/course11_img1/600/400" },
                    { 32L, 11L, "https://picsum.photos/seed/course11_img2/600/400" },
                    { 33L, 11L, "https://picsum.photos/seed/course11_img3/600/400" },
                    { 34L, 12L, "https://picsum.photos/seed/course12_img1/600/400" },
                    { 35L, 12L, "https://picsum.photos/seed/course12_img2/600/400" },
                    { 36L, 12L, "https://picsum.photos/seed/course12_img3/600/400" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "ModuleId", "CourseId", "DateCreated", "ModifiedDate", "ModuleName", "ModuleNumber", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 1", 1, 0 },
                    { 2L, 1L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 1", 2, 1 },
                    { 3L, 1L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 1", 3, 2 },
                    { 4L, 2L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 2", 1, 0 },
                    { 5L, 2L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 2", 2, 1 },
                    { 6L, 2L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 2", 3, 2 },
                    { 7L, 3L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 3", 1, 0 },
                    { 8L, 3L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 3", 2, 1 },
                    { 9L, 3L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 3", 3, 2 },
                    { 10L, 4L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 4", 1, 0 },
                    { 11L, 4L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 4", 2, 1 },
                    { 12L, 4L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 4", 3, 2 },
                    { 13L, 5L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 5", 1, 0 },
                    { 14L, 5L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 5", 2, 1 },
                    { 15L, 5L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 5", 3, 2 },
                    { 16L, 6L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 6", 1, 0 },
                    { 17L, 6L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 6", 2, 1 },
                    { 18L, 6L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 6", 3, 2 },
                    { 19L, 7L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 7", 1, 0 },
                    { 20L, 7L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 7", 2, 1 },
                    { 21L, 7L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 7", 3, 2 },
                    { 22L, 8L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 8", 1, 0 },
                    { 23L, 8L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 8", 2, 1 },
                    { 24L, 8L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 8", 3, 2 },
                    { 25L, 9L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 9", 1, 0 },
                    { 26L, 9L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 9", 2, 1 },
                    { 27L, 9L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 9", 3, 2 },
                    { 28L, 10L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 10", 1, 0 },
                    { 29L, 10L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 10", 2, 1 },
                    { 30L, 10L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 10", 3, 2 },
                    { 31L, 11L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 11", 1, 0 },
                    { 32L, 11L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 11", 2, 1 },
                    { 33L, 11L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 11", 3, 2 },
                    { 34L, 12L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 12", 1, 0 },
                    { 35L, 12L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 12", 2, 1 },
                    { 36L, 12L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 12", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "CourseId", "DateCreated", "Feedback", "ModifiedDate", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great course, very helpful!", null, (byte)5, "3" },
                    { 2L, 1L, new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good explanation but can be improved.", null, (byte)4, "4" },
                    { 3L, 2L, new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excellent content!", null, (byte)5, "5" },
                    { 4L, 2L, new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Average, expected more details.", null, (byte)3, "6" },
                    { 5L, 3L, new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Well structured and clear.", null, (byte)4, "7" },
                    { 6L, 3L, new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loved the practical examples.", null, (byte)5, "8" },
                    { 7L, 4L, new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Too basic for me.", null, (byte)2, "9" },
                    { 8L, 4L, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good for beginners.", null, (byte)4, "10" },
                    { 9L, 5L, new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Outstanding course!", null, (byte)5, "11" },
                    { 10L, 5L, new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoyed the teaching style.", null, (byte)4, "12" }
                });

            migrationBuilder.InsertData(
                table: "TransactionHistories",
                columns: new[] { "TransactionId", "Amount", "CourseId", "DateCreated", "Description", "ModifiedDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1L, 19.99m, 1L, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Purchase course 1", null, 1, "3" },
                    { 2L, 29.99m, 2L, new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Purchase course 2", null, 1, "3" },
                    { 3L, 24.99m, 3L, new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending payment for course 3", null, 0, "3" },
                    { 4L, 34.99m, 4L, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Purchase course 4", null, 1, "3" },
                    { 5L, 39.99m, 5L, new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Failed transaction for course 5", null, 2, "3" },
                    { 6L, 44.99m, 6L, new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Purchase course 6", null, 1, "3" }
                });

            migrationBuilder.InsertData(
                table: "WishLists",
                columns: new[] { "CourseId", "UserId", "CreatedAt" },
                values: new object[,]
                {
                    { 1L, "3", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1L, "6", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "4", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "5", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "5", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, "6", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "3", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "CreatedAt", "DateCreated", "Duration", "LessonContent", "LessonName", "LessonNumber", "LessonVideo", "ModifiedDate", "ModuleId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 1.", "Lesson 1 of Module 1", 1, null, null, 1L, 0, null },
                    { 2L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 1.", "Lesson 2 of Module 1", 2, null, null, 1L, 1, null },
                    { 3L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 2.", "Lesson 1 of Module 2", 1, null, null, 2L, 0, null },
                    { 4L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 2.", "Lesson 2 of Module 2", 2, null, null, 2L, 1, null },
                    { 5L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 3.", "Lesson 1 of Module 3", 1, null, null, 3L, 0, null },
                    { 6L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 3.", "Lesson 2 of Module 3", 2, null, null, 3L, 1, null },
                    { 7L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 4.", "Lesson 1 of Module 4", 1, null, null, 4L, 0, null },
                    { 8L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 4.", "Lesson 2 of Module 4", 2, null, null, 4L, 1, null },
                    { 9L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 5.", "Lesson 1 of Module 5", 1, null, null, 5L, 0, null },
                    { 10L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 5.", "Lesson 2 of Module 5", 2, null, null, 5L, 1, null },
                    { 11L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 6.", "Lesson 1 of Module 6", 1, null, null, 6L, 0, null },
                    { 12L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 6.", "Lesson 2 of Module 6", 2, null, null, 6L, 1, null },
                    { 13L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 7.", "Lesson 1 of Module 7", 1, null, null, 7L, 0, null },
                    { 14L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 7.", "Lesson 2 of Module 7", 2, null, null, 7L, 1, null },
                    { 15L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 8.", "Lesson 1 of Module 8", 1, null, null, 8L, 0, null },
                    { 16L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 8.", "Lesson 2 of Module 8", 2, null, null, 8L, 1, null },
                    { 17L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 9.", "Lesson 1 of Module 9", 1, null, null, 9L, 0, null },
                    { 18L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 9.", "Lesson 2 of Module 9", 2, null, null, 9L, 1, null },
                    { 19L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 10.", "Lesson 1 of Module 10", 1, null, null, 10L, 0, null },
                    { 20L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 10.", "Lesson 2 of Module 10", 2, null, null, 10L, 1, null },
                    { 21L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 11.", "Lesson 1 of Module 11", 1, null, null, 11L, 0, null },
                    { 22L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 11.", "Lesson 2 of Module 11", 2, null, null, 11L, 1, null },
                    { 23L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 12.", "Lesson 1 of Module 12", 1, null, null, 12L, 0, null },
                    { 24L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 12.", "Lesson 2 of Module 12", 2, null, null, 12L, 1, null },
                    { 25L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 13.", "Lesson 1 of Module 13", 1, null, null, 13L, 0, null },
                    { 26L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 13.", "Lesson 2 of Module 13", 2, null, null, 13L, 1, null },
                    { 27L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 14.", "Lesson 1 of Module 14", 1, null, null, 14L, 0, null },
                    { 28L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 14.", "Lesson 2 of Module 14", 2, null, null, 14L, 1, null },
                    { 29L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 15.", "Lesson 1 of Module 15", 1, null, null, 15L, 0, null },
                    { 30L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 15.", "Lesson 2 of Module 15", 2, null, null, 15L, 1, null },
                    { 31L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 16.", "Lesson 1 of Module 16", 1, null, null, 16L, 0, null },
                    { 32L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 16.", "Lesson 2 of Module 16", 2, null, null, 16L, 1, null },
                    { 33L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 17.", "Lesson 1 of Module 17", 1, null, null, 17L, 0, null },
                    { 34L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 17.", "Lesson 2 of Module 17", 2, null, null, 17L, 1, null },
                    { 35L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 18.", "Lesson 1 of Module 18", 1, null, null, 18L, 0, null },
                    { 36L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 18.", "Lesson 2 of Module 18", 2, null, null, 18L, 1, null },
                    { 37L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 19.", "Lesson 1 of Module 19", 1, null, null, 19L, 0, null },
                    { 38L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 19.", "Lesson 2 of Module 19", 2, null, null, 19L, 1, null },
                    { 39L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 20.", "Lesson 1 of Module 20", 1, null, null, 20L, 0, null },
                    { 40L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 20.", "Lesson 2 of Module 20", 2, null, null, 20L, 1, null },
                    { 41L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 21.", "Lesson 1 of Module 21", 1, null, null, 21L, 0, null },
                    { 42L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 21.", "Lesson 2 of Module 21", 2, null, null, 21L, 1, null },
                    { 43L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 22.", "Lesson 1 of Module 22", 1, null, null, 22L, 0, null },
                    { 44L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 22.", "Lesson 2 of Module 22", 2, null, null, 22L, 1, null },
                    { 45L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 23.", "Lesson 1 of Module 23", 1, null, null, 23L, 0, null },
                    { 46L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 23.", "Lesson 2 of Module 23", 2, null, null, 23L, 1, null },
                    { 47L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 24.", "Lesson 1 of Module 24", 1, null, null, 24L, 0, null },
                    { 48L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 24.", "Lesson 2 of Module 24", 2, null, null, 24L, 1, null },
                    { 49L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 25.", "Lesson 1 of Module 25", 1, null, null, 25L, 0, null },
                    { 50L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 25.", "Lesson 2 of Module 25", 2, null, null, 25L, 1, null },
                    { 51L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 26.", "Lesson 1 of Module 26", 1, null, null, 26L, 0, null },
                    { 52L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 26.", "Lesson 2 of Module 26", 2, null, null, 26L, 1, null },
                    { 53L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 27.", "Lesson 1 of Module 27", 1, null, null, 27L, 0, null },
                    { 54L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 27.", "Lesson 2 of Module 27", 2, null, null, 27L, 1, null },
                    { 55L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 28.", "Lesson 1 of Module 28", 1, null, null, 28L, 0, null },
                    { 56L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 28.", "Lesson 2 of Module 28", 2, null, null, 28L, 1, null },
                    { 57L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 29.", "Lesson 1 of Module 29", 1, null, null, 29L, 0, null },
                    { 58L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 29.", "Lesson 2 of Module 29", 2, null, null, 29L, 1, null },
                    { 59L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 30.", "Lesson 1 of Module 30", 1, null, null, 30L, 0, null },
                    { 60L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 30.", "Lesson 2 of Module 30", 2, null, null, 30L, 1, null },
                    { 61L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 31.", "Lesson 1 of Module 31", 1, null, null, 31L, 0, null },
                    { 62L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 31.", "Lesson 2 of Module 31", 2, null, null, 31L, 1, null },
                    { 63L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 32.", "Lesson 1 of Module 32", 1, null, null, 32L, 0, null },
                    { 64L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 32.", "Lesson 2 of Module 32", 2, null, null, 32L, 1, null },
                    { 65L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 33.", "Lesson 1 of Module 33", 1, null, null, 33L, 0, null },
                    { 66L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 33.", "Lesson 2 of Module 33", 2, null, null, 33L, 1, null },
                    { 67L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 34.", "Lesson 1 of Module 34", 1, null, null, 34L, 0, null },
                    { 68L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 34.", "Lesson 2 of Module 34", 2, null, null, 34L, 1, null },
                    { 69L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 35.", "Lesson 1 of Module 35", 1, null, null, 35L, 0, null },
                    { 70L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 35.", "Lesson 2 of Module 35", 2, null, null, 35L, 1, null },
                    { 71L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is the content for Lesson 1 of Module 36.", "Lesson 1 of Module 36", 1, null, null, 36L, 0, null },
                    { 72L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "This is the content for Lesson 2 of Module 36.", "Lesson 2 of Module 36", 2, null, null, 36L, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "QuizId", "CreatedAt", "DateCreated", "ModifiedDate", "ModuleId", "PassScore", "QuizName", "QuizTime", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, 70, "Quiz for Module 1", 20, null },
                    { 2L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2L, 70, "Quiz for Module 2", 20, null },
                    { 3L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3L, 70, "Quiz for Module 3", 20, null },
                    { 4L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4L, 70, "Quiz for Module 4", 20, null },
                    { 5L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5L, 70, "Quiz for Module 5", 20, null },
                    { 6L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6L, 70, "Quiz for Module 6", 20, null },
                    { 7L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7L, 70, "Quiz for Module 7", 20, null },
                    { 8L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8L, 70, "Quiz for Module 8", 20, null },
                    { 9L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9L, 70, "Quiz for Module 9", 20, null },
                    { 10L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10L, 70, "Quiz for Module 10", 20, null },
                    { 11L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11L, 70, "Quiz for Module 11", 20, null },
                    { 12L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12L, 70, "Quiz for Module 12", 20, null }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "DateCreated", "ModifiedDate", "QuestionContent", "QuestionNum", "QuizId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 1", 1, 1L },
                    { 2L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 1", 2, 1L },
                    { 3L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 1", 3, 1L },
                    { 4L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 1", 4, 1L },
                    { 5L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 1", 5, 1L },
                    { 6L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 2", 1, 2L },
                    { 7L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 2", 2, 2L },
                    { 8L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 2", 3, 2L },
                    { 9L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 2", 4, 2L },
                    { 10L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 2", 5, 2L },
                    { 11L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 3", 1, 3L },
                    { 12L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 3", 2, 3L },
                    { 13L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 3", 3, 3L },
                    { 14L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 3", 4, 3L },
                    { 15L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 3", 5, 3L },
                    { 16L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 4", 1, 4L },
                    { 17L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 4", 2, 4L },
                    { 18L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 4", 3, 4L },
                    { 19L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 4", 4, 4L },
                    { 20L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 4", 5, 4L },
                    { 21L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 5", 1, 5L },
                    { 22L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 5", 2, 5L },
                    { 23L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 5", 3, 5L },
                    { 24L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 5", 4, 5L },
                    { 25L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 5", 5, 5L },
                    { 26L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 6", 1, 6L },
                    { 27L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 6", 2, 6L },
                    { 28L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 6", 3, 6L },
                    { 29L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 6", 4, 6L },
                    { 30L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 6", 5, 6L },
                    { 31L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 7", 1, 7L },
                    { 32L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 7", 2, 7L },
                    { 33L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 7", 3, 7L },
                    { 34L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 7", 4, 7L },
                    { 35L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 7", 5, 7L },
                    { 36L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 8", 1, 8L },
                    { 37L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 8", 2, 8L },
                    { 38L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 8", 3, 8L },
                    { 39L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 8", 4, 8L },
                    { 40L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 8", 5, 8L },
                    { 41L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 9", 1, 9L },
                    { 42L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 9", 2, 9L },
                    { 43L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 9", 3, 9L },
                    { 44L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 9", 4, 9L },
                    { 45L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 9", 5, 9L },
                    { 46L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 10", 1, 10L },
                    { 47L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 10", 2, 10L },
                    { 48L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 10", 3, 10L },
                    { 49L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 10", 4, 10L },
                    { 50L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 10", 5, 10L },
                    { 51L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 11", 1, 11L },
                    { 52L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 11", 2, 11L },
                    { 53L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 11", 3, 11L },
                    { 54L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 11", 4, 11L },
                    { 55L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 11", 5, 11L },
                    { 56L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 1 for Quiz 12", 1, 12L },
                    { 57L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 2 for Quiz 12", 2, 12L },
                    { 58L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 3 for Quiz 12", 3, 12L },
                    { 59L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 4 for Quiz 12", 4, 12L },
                    { 60L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Question 5 for Quiz 12", 5, 12L }
                });

            migrationBuilder.InsertData(
                table: "QuizResults",
                columns: new[] { "QuizResultId", "CorrectAnswers", "CreatedAt", "EndTime", "QuizId", "Score", "StartTime", "TotalQuestions", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 1L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5380), "3" },
                    { 2L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 1L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5402), "4" },
                    { 3L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 2L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5406), "3" },
                    { 4L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 2L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5409), "4" },
                    { 5L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 3L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5411), "3" },
                    { 6L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 3L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5415), "4" },
                    { 7L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 4L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5417), "3" },
                    { 8L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 4L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5419), "4" },
                    { 9L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 5L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5421), "3" },
                    { 10L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 5L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5424), "4" },
                    { 11L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 6L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5426), "3" },
                    { 12L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 6L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5427), "4" },
                    { 13L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 7L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5429), "3" },
                    { 14L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 7L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5485), "4" },
                    { 15L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 8L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5486), "3" },
                    { 16L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 8L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5488), "4" },
                    { 17L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 9L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5490), "3" },
                    { 18L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 9L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5493), "4" },
                    { 19L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 10L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5494), "3" },
                    { 20L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 10L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5496), "4" },
                    { 21L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 11L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5498), "3" },
                    { 22L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 11L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5499), "4" },
                    { 23L, 4, new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 12L, 80.00m, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5501), "3" },
                    { 24L, 3, new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 12L, 60.00m, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5502), "4" }
                });

            migrationBuilder.InsertData(
                table: "AnswerQuizzes",
                columns: new[] { "AnswerQuizId", "DateCreated", "IsCorrect", "ModifiedDate", "OptionId", "QuestionId", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 0L, 1L, "3" },
                    { 2L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 0L, 1L, "4" },
                    { 3L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 4L, 2L, "3" },
                    { 4L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 4L, 2L, "4" },
                    { 5L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 8L, 3L, "3" },
                    { 6L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 8L, 3L, "4" },
                    { 7L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 12L, 4L, "3" },
                    { 8L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 13L, 4L, "4" },
                    { 9L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 17L, 5L, "3" },
                    { 10L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 17L, 5L, "4" },
                    { 11L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 20L, 6L, "3" },
                    { 12L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 20L, 6L, "4" },
                    { 13L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 24L, 7L, "3" },
                    { 14L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 24L, 7L, "4" },
                    { 15L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 28L, 8L, "3" },
                    { 16L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 28L, 8L, "4" },
                    { 17L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 32L, 9L, "3" },
                    { 18L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 33L, 9L, "4" },
                    { 19L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 37L, 10L, "3" },
                    { 20L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 37L, 10L, "4" },
                    { 21L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 40L, 11L, "3" },
                    { 22L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 40L, 11L, "4" },
                    { 23L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 44L, 12L, "3" },
                    { 24L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 44L, 12L, "4" },
                    { 25L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 48L, 13L, "3" },
                    { 26L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 48L, 13L, "4" },
                    { 27L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 52L, 14L, "3" },
                    { 28L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 53L, 14L, "4" },
                    { 29L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 57L, 15L, "3" },
                    { 30L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 57L, 15L, "4" },
                    { 31L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 60L, 16L, "3" },
                    { 32L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 60L, 16L, "4" },
                    { 33L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 64L, 17L, "3" },
                    { 34L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 64L, 17L, "4" },
                    { 35L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 68L, 18L, "3" },
                    { 36L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 68L, 18L, "4" },
                    { 37L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 72L, 19L, "3" },
                    { 38L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 73L, 19L, "4" },
                    { 39L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 77L, 20L, "3" },
                    { 40L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 77L, 20L, "4" },
                    { 41L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 80L, 21L, "3" },
                    { 42L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 80L, 21L, "4" },
                    { 43L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 84L, 22L, "3" },
                    { 44L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 84L, 22L, "4" },
                    { 45L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 88L, 23L, "3" },
                    { 46L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 88L, 23L, "4" },
                    { 47L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 92L, 24L, "3" },
                    { 48L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 93L, 24L, "4" },
                    { 49L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 97L, 25L, "3" },
                    { 50L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 97L, 25L, "4" },
                    { 51L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 100L, 26L, "3" },
                    { 52L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 100L, 26L, "4" },
                    { 53L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 104L, 27L, "3" },
                    { 54L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 104L, 27L, "4" },
                    { 55L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 108L, 28L, "3" },
                    { 56L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 108L, 28L, "4" },
                    { 57L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 112L, 29L, "3" },
                    { 58L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 113L, 29L, "4" },
                    { 59L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 117L, 30L, "3" },
                    { 60L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 117L, 30L, "4" },
                    { 61L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 120L, 31L, "3" },
                    { 62L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 120L, 31L, "4" },
                    { 63L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 124L, 32L, "3" },
                    { 64L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 124L, 32L, "4" },
                    { 65L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 128L, 33L, "3" },
                    { 66L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 128L, 33L, "4" },
                    { 67L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 132L, 34L, "3" },
                    { 68L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 133L, 34L, "4" },
                    { 69L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 137L, 35L, "3" },
                    { 70L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 137L, 35L, "4" },
                    { 71L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 140L, 36L, "3" },
                    { 72L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 140L, 36L, "4" },
                    { 73L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 144L, 37L, "3" },
                    { 74L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 144L, 37L, "4" },
                    { 75L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 148L, 38L, "3" },
                    { 76L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 148L, 38L, "4" },
                    { 77L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 152L, 39L, "3" },
                    { 78L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 153L, 39L, "4" },
                    { 79L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 157L, 40L, "3" },
                    { 80L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 157L, 40L, "4" },
                    { 81L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 160L, 41L, "3" },
                    { 82L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 160L, 41L, "4" },
                    { 83L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 164L, 42L, "3" },
                    { 84L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 164L, 42L, "4" },
                    { 85L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 168L, 43L, "3" },
                    { 86L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 168L, 43L, "4" },
                    { 87L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 172L, 44L, "3" },
                    { 88L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 173L, 44L, "4" },
                    { 89L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 177L, 45L, "3" },
                    { 90L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 177L, 45L, "4" },
                    { 91L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 180L, 46L, "3" },
                    { 92L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 180L, 46L, "4" },
                    { 93L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 184L, 47L, "3" },
                    { 94L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 184L, 47L, "4" },
                    { 95L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 188L, 48L, "3" },
                    { 96L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 188L, 48L, "4" },
                    { 97L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 192L, 49L, "3" },
                    { 98L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 193L, 49L, "4" },
                    { 99L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 197L, 50L, "3" },
                    { 100L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 197L, 50L, "4" },
                    { 101L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 200L, 51L, "3" },
                    { 102L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 200L, 51L, "4" },
                    { 103L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 204L, 52L, "3" },
                    { 104L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 204L, 52L, "4" },
                    { 105L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 208L, 53L, "3" },
                    { 106L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 208L, 53L, "4" },
                    { 107L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 212L, 54L, "3" },
                    { 108L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 213L, 54L, "4" },
                    { 109L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 217L, 55L, "3" },
                    { 110L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 217L, 55L, "4" },
                    { 111L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 220L, 56L, "3" },
                    { 112L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 220L, 56L, "4" },
                    { 113L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 224L, 57L, "3" },
                    { 114L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 224L, 57L, "4" },
                    { 115L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 228L, 58L, "3" },
                    { 116L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 228L, 58L, "4" },
                    { 117L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 232L, 59L, "3" },
                    { 118L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 233L, 59L, "4" },
                    { 119L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 237L, 60L, "3" },
                    { 120L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 237L, 60L, "4" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "OptionId", "DateCreated", "IsCorrect", "ModifiedDate", "OptionText", "QuestionId", "Status" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 1", 1L, 0 },
                    { 2L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 1", 1L, 0 },
                    { 3L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 1", 1L, 0 },
                    { 4L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 1", 1L, 0 },
                    { 5L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 2", 2L, 0 },
                    { 6L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 2", 2L, 0 },
                    { 7L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 2", 2L, 0 },
                    { 8L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 2", 2L, 0 },
                    { 9L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 3", 3L, 0 },
                    { 10L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 3", 3L, 0 },
                    { 11L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 3", 3L, 0 },
                    { 12L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 3", 3L, 0 },
                    { 13L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 4", 4L, 0 },
                    { 14L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 4", 4L, 0 },
                    { 15L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 4", 4L, 0 },
                    { 16L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 4", 4L, 0 },
                    { 17L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 5", 5L, 0 },
                    { 18L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 5", 5L, 0 },
                    { 19L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 5", 5L, 0 },
                    { 20L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 5", 5L, 0 },
                    { 21L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 6", 6L, 0 },
                    { 22L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 6", 6L, 0 },
                    { 23L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 6", 6L, 0 },
                    { 24L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 6", 6L, 0 },
                    { 25L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 7", 7L, 0 },
                    { 26L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 7", 7L, 0 },
                    { 27L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 7", 7L, 0 },
                    { 28L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 7", 7L, 0 },
                    { 29L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 8", 8L, 0 },
                    { 30L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 8", 8L, 0 },
                    { 31L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 8", 8L, 0 },
                    { 32L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 8", 8L, 0 },
                    { 33L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 9", 9L, 0 },
                    { 34L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 9", 9L, 0 },
                    { 35L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 9", 9L, 0 },
                    { 36L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 9", 9L, 0 },
                    { 37L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 10", 10L, 0 },
                    { 38L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 10", 10L, 0 },
                    { 39L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 10", 10L, 0 },
                    { 40L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 10", 10L, 0 },
                    { 41L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 11", 11L, 0 },
                    { 42L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 11", 11L, 0 },
                    { 43L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 11", 11L, 0 },
                    { 44L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 11", 11L, 0 },
                    { 45L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 12", 12L, 0 },
                    { 46L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 12", 12L, 0 },
                    { 47L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 12", 12L, 0 },
                    { 48L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 12", 12L, 0 },
                    { 49L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 13", 13L, 0 },
                    { 50L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 13", 13L, 0 },
                    { 51L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 13", 13L, 0 },
                    { 52L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 13", 13L, 0 },
                    { 53L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 14", 14L, 0 },
                    { 54L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 14", 14L, 0 },
                    { 55L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 14", 14L, 0 },
                    { 56L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 14", 14L, 0 },
                    { 57L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 15", 15L, 0 },
                    { 58L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 15", 15L, 0 },
                    { 59L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 15", 15L, 0 },
                    { 60L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 15", 15L, 0 },
                    { 61L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 16", 16L, 0 },
                    { 62L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 16", 16L, 0 },
                    { 63L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 16", 16L, 0 },
                    { 64L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 16", 16L, 0 },
                    { 65L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 17", 17L, 0 },
                    { 66L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 17", 17L, 0 },
                    { 67L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 17", 17L, 0 },
                    { 68L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 17", 17L, 0 },
                    { 69L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 18", 18L, 0 },
                    { 70L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 18", 18L, 0 },
                    { 71L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 18", 18L, 0 },
                    { 72L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 18", 18L, 0 },
                    { 73L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 19", 19L, 0 },
                    { 74L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 19", 19L, 0 },
                    { 75L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 19", 19L, 0 },
                    { 76L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 19", 19L, 0 },
                    { 77L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 20", 20L, 0 },
                    { 78L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 20", 20L, 0 },
                    { 79L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 20", 20L, 0 },
                    { 80L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 20", 20L, 0 },
                    { 81L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 21", 21L, 0 },
                    { 82L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 21", 21L, 0 },
                    { 83L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 21", 21L, 0 },
                    { 84L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 21", 21L, 0 },
                    { 85L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 22", 22L, 0 },
                    { 86L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 22", 22L, 0 },
                    { 87L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 22", 22L, 0 },
                    { 88L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 22", 22L, 0 },
                    { 89L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 23", 23L, 0 },
                    { 90L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 23", 23L, 0 },
                    { 91L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 23", 23L, 0 },
                    { 92L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 23", 23L, 0 },
                    { 93L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 24", 24L, 0 },
                    { 94L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 24", 24L, 0 },
                    { 95L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 24", 24L, 0 },
                    { 96L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 24", 24L, 0 },
                    { 97L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 25", 25L, 0 },
                    { 98L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 25", 25L, 0 },
                    { 99L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 25", 25L, 0 },
                    { 100L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 25", 25L, 0 },
                    { 101L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 26", 26L, 0 },
                    { 102L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 26", 26L, 0 },
                    { 103L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 26", 26L, 0 },
                    { 104L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 26", 26L, 0 },
                    { 105L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 27", 27L, 0 },
                    { 106L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 27", 27L, 0 },
                    { 107L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 27", 27L, 0 },
                    { 108L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 27", 27L, 0 },
                    { 109L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 28", 28L, 0 },
                    { 110L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 28", 28L, 0 },
                    { 111L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 28", 28L, 0 },
                    { 112L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 28", 28L, 0 },
                    { 113L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 29", 29L, 0 },
                    { 114L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 29", 29L, 0 },
                    { 115L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 29", 29L, 0 },
                    { 116L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 29", 29L, 0 },
                    { 117L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 30", 30L, 0 },
                    { 118L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 30", 30L, 0 },
                    { 119L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 30", 30L, 0 },
                    { 120L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 30", 30L, 0 },
                    { 121L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 31", 31L, 0 },
                    { 122L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 31", 31L, 0 },
                    { 123L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 31", 31L, 0 },
                    { 124L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 31", 31L, 0 },
                    { 125L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 32", 32L, 0 },
                    { 126L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 32", 32L, 0 },
                    { 127L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 32", 32L, 0 },
                    { 128L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 32", 32L, 0 },
                    { 129L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 33", 33L, 0 },
                    { 130L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 33", 33L, 0 },
                    { 131L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 33", 33L, 0 },
                    { 132L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 33", 33L, 0 },
                    { 133L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 34", 34L, 0 },
                    { 134L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 34", 34L, 0 },
                    { 135L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 34", 34L, 0 },
                    { 136L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 34", 34L, 0 },
                    { 137L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 35", 35L, 0 },
                    { 138L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 35", 35L, 0 },
                    { 139L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 35", 35L, 0 },
                    { 140L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 35", 35L, 0 },
                    { 141L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 36", 36L, 0 },
                    { 142L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 36", 36L, 0 },
                    { 143L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 36", 36L, 0 },
                    { 144L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 36", 36L, 0 },
                    { 145L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 37", 37L, 0 },
                    { 146L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 37", 37L, 0 },
                    { 147L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 37", 37L, 0 },
                    { 148L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 37", 37L, 0 },
                    { 149L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 38", 38L, 0 },
                    { 150L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 38", 38L, 0 },
                    { 151L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 38", 38L, 0 },
                    { 152L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 38", 38L, 0 },
                    { 153L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 39", 39L, 0 },
                    { 154L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 39", 39L, 0 },
                    { 155L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 39", 39L, 0 },
                    { 156L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 39", 39L, 0 },
                    { 157L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 40", 40L, 0 },
                    { 158L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 40", 40L, 0 },
                    { 159L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 40", 40L, 0 },
                    { 160L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 40", 40L, 0 },
                    { 161L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 41", 41L, 0 },
                    { 162L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 41", 41L, 0 },
                    { 163L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 41", 41L, 0 },
                    { 164L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 41", 41L, 0 },
                    { 165L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 42", 42L, 0 },
                    { 166L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 42", 42L, 0 },
                    { 167L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 42", 42L, 0 },
                    { 168L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 42", 42L, 0 },
                    { 169L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 43", 43L, 0 },
                    { 170L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 43", 43L, 0 },
                    { 171L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 43", 43L, 0 },
                    { 172L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 43", 43L, 0 },
                    { 173L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 44", 44L, 0 },
                    { 174L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 44", 44L, 0 },
                    { 175L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 44", 44L, 0 },
                    { 176L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 44", 44L, 0 },
                    { 177L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 45", 45L, 0 },
                    { 178L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 45", 45L, 0 },
                    { 179L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 45", 45L, 0 },
                    { 180L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 45", 45L, 0 },
                    { 181L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 46", 46L, 0 },
                    { 182L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 46", 46L, 0 },
                    { 183L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 46", 46L, 0 },
                    { 184L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 46", 46L, 0 },
                    { 185L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 47", 47L, 0 },
                    { 186L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 47", 47L, 0 },
                    { 187L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 47", 47L, 0 },
                    { 188L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 47", 47L, 0 },
                    { 189L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 48", 48L, 0 },
                    { 190L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 48", 48L, 0 },
                    { 191L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 48", 48L, 0 },
                    { 192L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 48", 48L, 0 },
                    { 193L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 49", 49L, 0 },
                    { 194L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 49", 49L, 0 },
                    { 195L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 49", 49L, 0 },
                    { 196L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 49", 49L, 0 },
                    { 197L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 50", 50L, 0 },
                    { 198L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 50", 50L, 0 },
                    { 199L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 50", 50L, 0 },
                    { 200L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 50", 50L, 0 },
                    { 201L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 51", 51L, 0 },
                    { 202L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 51", 51L, 0 },
                    { 203L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 51", 51L, 0 },
                    { 204L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 51", 51L, 0 },
                    { 205L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 52", 52L, 0 },
                    { 206L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 52", 52L, 0 },
                    { 207L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 52", 52L, 0 },
                    { 208L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 52", 52L, 0 },
                    { 209L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 53", 53L, 0 },
                    { 210L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 53", 53L, 0 },
                    { 211L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 53", 53L, 0 },
                    { 212L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 53", 53L, 0 },
                    { 213L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 54", 54L, 0 },
                    { 214L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 54", 54L, 0 },
                    { 215L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 54", 54L, 0 },
                    { 216L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 54", 54L, 0 },
                    { 217L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 55", 55L, 0 },
                    { 218L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 55", 55L, 0 },
                    { 219L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 55", 55L, 0 },
                    { 220L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 55", 55L, 0 },
                    { 221L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 56", 56L, 0 },
                    { 222L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 56", 56L, 0 },
                    { 223L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 56", 56L, 0 },
                    { 224L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 56", 56L, 0 },
                    { 225L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 57", 57L, 0 },
                    { 226L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 57", 57L, 0 },
                    { 227L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 57", 57L, 0 },
                    { 228L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 57", 57L, 0 },
                    { 229L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 58", 58L, 0 },
                    { 230L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 58", 58L, 0 },
                    { 231L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 58", 58L, 0 },
                    { 232L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 58", 58L, 0 },
                    { 233L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 59", 59L, 0 },
                    { 234L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 59", 59L, 0 },
                    { 235L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 59", 59L, 0 },
                    { 236L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 59", 59L, 0 },
                    { 237L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Option 1 for Question 60", 60L, 0 },
                    { 238L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 2 for Question 60", 60L, 0 },
                    { 239L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 3 for Question 60", 60L, 0 },
                    { 240L, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Option 4 for Question 60", 60L, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 1L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 1L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "3" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "4" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, "8" });

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "OptionId",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "admin-role");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "mentor-role");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "student-role");

            migrationBuilder.DeleteData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "3" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "4" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, "3" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "LevelId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
