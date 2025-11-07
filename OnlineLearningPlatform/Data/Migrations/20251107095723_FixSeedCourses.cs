using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LevelName",
                table: "Levels",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1L,
                columns: new[] { "CourseName", "Description", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Sample Course 1", "This is a short description for sample course number 1.", 499000m, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status" },
                values: new object[] { "Sample Course 2", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 2.", 509000m, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Sample Course 3", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 3.", 0m, 519000m, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Sample Course 4", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 4.", 50000m, 529000m, new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Sample Course 5", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 5.", 539000m, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Sample Course 6", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 6.", 0m, 549000m, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status", "UpdatedAt" },
                values: new object[] { "Sample Course 7", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 7.", 559000m, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Sample Course 8", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 8.", 50000m, 569000m, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Sample Course 9", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 9.", 0m, 579000m, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Sample Course 10", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 10.", 589000m, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Sample Course 11", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 11.", 599000m, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "UpdatedAt" },
                values: new object[] { "Sample Course 12", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a short description for sample course number 12.", 50000m, 609000m, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Acceptor", "CourseName", "CreatedAt", "Creator", "DeletedAt", "Description", "Discount", "LevelId", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[,]
                {
                    { 13L, "1", "Sample Course 13", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 13.", 0m, 2L, 619000m, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14L, "1", "Sample Course 14", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 14.", 0m, 3L, 629000m, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15L, "1", "Sample Course 15", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 15.", 0m, 1L, 639000m, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16L, "1", "Sample Course 16", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 16.", 50000m, 2L, 649000m, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17L, "1", "Sample Course 17", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 17.", 0m, 3L, 659000m, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "5 hours", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18L, "1", "Sample Course 18", new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 18.", 0m, 1L, 669000m, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19L, "1", "Sample Course 19", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 19.", 0m, 2L, 679000m, new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20L, "1", "Sample Course 20", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 20.", 50000m, 3L, 689000m, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21L, "1", "Sample Course 21", new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 21.", 0m, 1L, 699000m, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22L, "1", "Sample Course 22", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 22.", 0m, 2L, 709000m, new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "5 hours", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23L, "1", "Sample Course 23", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 23.", 0m, 3L, 719000m, new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24L, "1", "Sample Course 24", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 24.", 50000m, 1L, 729000m, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25L, "1", "Sample Course 25", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 25.", 0m, 2L, 739000m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26L, "1", "Sample Course 26", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 26.", 0m, 3L, 749000m, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27L, "1", "Sample Course 27", new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 27.", 0m, 1L, 759000m, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "5 hours", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28L, "1", "Sample Course 28", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 28.", 50000m, 2L, 769000m, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29L, "1", "Sample Course 29", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 29.", 0m, 3L, 779000m, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30L, "1", "Sample Course 30", new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 30.", 0m, 1L, 789000m, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31L, "1", "Sample Course 31", new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 31.", 0m, 2L, 799000m, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32L, "1", "Sample Course 32", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 32.", 50000m, 3L, 809000m, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "5 hours", new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33L, "1", "Sample Course 33", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 33.", 0m, 1L, 819000m, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34L, "1", "Sample Course 34", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 34.", 0m, 2L, 829000m, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35L, "1", "Sample Course 35", new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 35.", 0m, 3L, 839000m, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36L, "1", "Sample Course 36", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 36.", 50000m, 1L, 849000m, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37L, "1", "Sample Course 37", new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 37.", 0m, 2L, 859000m, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "5 hours", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38L, "1", "Sample Course 38", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 38.", 0m, 3L, 869000m, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39L, "1", "Sample Course 39", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 39.", 0m, 1L, 879000m, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40L, "1", "Sample Course 40", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 40.", 50000m, 2L, 889000m, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41L, "1", "Sample Course 41", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 41.", 0m, 3L, 899000m, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42L, "1", "Sample Course 42", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 42.", 0m, 1L, 909000m, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "5 hours", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43L, "1", "Sample Course 43", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 43.", 0m, 2L, 919000m, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44L, "1", "Sample Course 44", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 44.", 50000m, 3L, 929000m, new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45L, "1", "Sample Course 45", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 45.", 0m, 1L, 939000m, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46L, "1", "Sample Course 46", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 46.", 0m, 2L, 949000m, new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "4 hours", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47L, "1", "Sample Course 47", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 47.", 0m, 3L, 959000m, new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "5 hours", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48L, "1", "Sample Course 48", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 48.", 50000m, 1L, 969000m, new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "6 hours", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49L, "1", "Sample Course 49", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 49.", 0m, 2L, 979000m, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "7 hours", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50L, "1", "Sample Course 50", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", null, "This is a short description for sample course number 50.", 0m, 3L, 989000m, new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "3 hours", new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 16, 57, 20, 690, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f4e6d674-ab4c-4a0b-82f7-bfb89def1e2f", "AQAAAAIAAYagAAAAEFrG+h3c2j/VwMoFsJtRJ2kPibAiLRwiDXkvjrt8Qcr+iOu/TTl6xkF4/o08bR8bYA==", "a07051d3-c76d-4eec-aa4a-0f4f7b54fa60", new DateTime(2025, 11, 7, 16, 57, 20, 691, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c9be355e-89d4-403c-82d8-9a5c4f626a28", "AQAAAAIAAYagAAAAELH+Lt+E5N1cS8PFwIKDqYOE1T0Iimkl7PI2kSuw8uOvgMikze9kU/zl079XFfVKog==", "7a0127e7-7a0e-48c6-a552-c64b124f65fc", new DateTime(2025, 11, 7, 16, 57, 21, 64, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8c9b3354-8cbd-4113-99e7-e375dbed6edd", "AQAAAAIAAYagAAAAEOzLY0uwKWr61UmA3D+mjpST1dez1rNonry5bSj9cpu8D7MOSbcjWA15eG/Dkc5kiQ==", "928d63fa-e046-4de0-880b-5aefbc1d3fc6", new DateTime(2025, 11, 7, 16, 57, 21, 109, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "eb19d12e-748a-47c1-8bbb-089aa5e1e0c7", "AQAAAAIAAYagAAAAEEePtxbfaRReeYyb58gqCvRMX4T0IpxAArFVre4OfGGw4cgSFP77IjHsgbaImvcLZQ==", "42ae8656-f857-4d70-a50e-e7772bca23f8", new DateTime(2025, 11, 7, 16, 57, 21, 151, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3531eddd-5ce3-4759-b640-791e7537d9fb", "AQAAAAIAAYagAAAAELNtMS/vTHjSHMF7TGw5NaEMquXpo6G69gWVHliDV1xnq2OGT6wPXE29r63bO3Ttdw==", "40614b00-6bce-4ce8-9b52-6692e79d9cd2", new DateTime(2025, 11, 7, 16, 57, 21, 191, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "04c1645e-c6e2-4507-80a1-9a0b8731258a", "AQAAAAIAAYagAAAAEMZ6LrP0ZQr9BgrSUK6X8bMo/6vZLgKUA9PwNDeX6QYcGdw+pU9IHET5T9758FhuLA==", "b3d5b7cf-37cc-4ecf-9393-ec107f37b5dd", new DateTime(2025, 11, 7, 16, 57, 21, 231, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3ab6f966-6e79-4e1a-9d91-d881ddb42f85", "AQAAAAIAAYagAAAAEBNty4bjI1qwSGj1LbBQ7aqfx7AB43Vq9oxCqghMxG3/6Svqr4sEz9aH6/5ZizvAVQ==", "192db995-aece-4c93-95da-c54ad828b182", new DateTime(2025, 11, 7, 16, 57, 21, 271, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d73abd9f-80bd-45dc-a8eb-6f40255d6e62", "AQAAAAIAAYagAAAAEC/Bq4BBlBDbgwD2hSlOhu6QC/Carc1X0WHiuvg9bW+RpnLKlf/yJlDL/ac2S7PYxA==", "0cdae581-d61c-4148-b585-c5e4c192779b", new DateTime(2025, 11, 7, 16, 57, 21, 312, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fb02af0c-75ca-4b9b-8451-c6263e2dae60", "AQAAAAIAAYagAAAAEMa26wfdTs5+jF+hsbKEGzmqT/DVGt+2Dx+l5jPT+VcOvBMUkQMThI7nT6yxQO9chg==", "d66763f6-6026-4f2b-a1ba-414db93fc633", new DateTime(2025, 11, 7, 16, 57, 21, 353, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cd755cb1-8678-4161-b56d-56c4d0ddf450", "AQAAAAIAAYagAAAAEHmRdL0nOtythyh1zKsWddbKYo4ww9d56ZWtJMH0R0pa++a9iHo578pwYX9WVW6cag==", "cd8407cd-162e-4597-a629-1e952557b266", new DateTime(2025, 11, 7, 16, 57, 21, 394, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bce5fd74-3eaf-4e13-bd1e-1dea59b68f72", "AQAAAAIAAYagAAAAELX4fNa3a+eFw3Cpsr71DwpyCuEOQywQzkEZrcJbp3mu0qX2eqgrLN9hMUto4H5aPA==", "a7c5c78e-fa72-4e8e-bed7-997af9edc8fe", new DateTime(2025, 11, 7, 16, 57, 21, 433, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "db92d8c6-068e-4cea-9816-6d63ac6ea829", "AQAAAAIAAYagAAAAEBA05t2L8z/4NClbrpXar0pTlVpcBmkqUaGIFdTFGAcsCDYIhwzEAhYyt3145LZYZQ==", "6f1abf91-2328-4400-b1ba-cb71c16b2de5", new DateTime(2025, 11, 7, 16, 57, 20, 733, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c8c8be1a-3452-449e-bc7f-88408c793071", "AQAAAAIAAYagAAAAEOXDy1Givapnr8YTY/8QhntnXGVzFhdkztz+61GNcZXcVVvcQLMHW2K2H40pyPtjJw==", "2894b4ce-64f0-4422-869b-e60814570f58", new DateTime(2025, 11, 7, 16, 57, 21, 473, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "36244d63-6088-4037-9f5d-3d28280afe1a", "AQAAAAIAAYagAAAAEHuxZMtb+S0KZm+umd80RjzLO6G9vo0xiHXd1mTzdbqQtABOZZRSUzjamEFHC9ZmtA==", "99d52cd5-eeca-4f95-8a07-e00f0ec2415b", new DateTime(2025, 11, 7, 16, 57, 21, 514, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "56448b8d-ef88-46e4-b1a1-b6f21c262878", "AQAAAAIAAYagAAAAEL8PtmA0ZQNxhfFv45R5V/mz/c35pBG6ceSiWVyh4WjtuTkN/Rn4rrmQeSH0hT+t0w==", "78263b8f-0ba8-4ad8-bff9-93aefa405048", new DateTime(2025, 11, 7, 16, 57, 21, 554, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "01554e26-ee05-47e6-aaff-5951190eeb88", "AQAAAAIAAYagAAAAEPI7He8AoIGgAj14ay0h3+sUJwyolBEuCZtSsGjpSpxDSlryfz4Iaf+VNuWj2o6sbw==", "06473fad-491b-4d69-9745-e34155face15", new DateTime(2025, 11, 7, 16, 57, 21, 593, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2368765c-9a08-4e56-a2cc-4b6244cc5661", "AQAAAAIAAYagAAAAEAU+9TVZvutHjnco14GsxAsyjnrMJdmX7UNez+9PSI5RVyFuGvTv27YSdv3wEhCS1g==", "12169883-a5be-478b-9782-269b1eecd213", new DateTime(2025, 11, 7, 16, 57, 21, 632, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d56fda2e-f84f-4583-93d2-dc9e3d04ce6f", "AQAAAAIAAYagAAAAED9R6XBSS0v9vJY3mA76oPwdhriSa7jIPjHjxOTXdhjBtZ8vyfyVomi4IgtR/qxRxQ==", "5a0f8499-7496-481e-9dcb-264e1db30685", new DateTime(2025, 11, 7, 16, 57, 21, 671, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cd50e159-f588-436b-977c-caef9acef743", "AQAAAAIAAYagAAAAEI4IjUgFJxJpJ+xTO7DDPp8nvM3BJbBrQTqxzsHHWurWBNTlHjt91XYWTN9R6kdqBg==", "fed82497-a682-4ffd-aebd-85eff756aacd", new DateTime(2025, 11, 7, 16, 57, 21, 714, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cd373bb5-2390-4fc0-9c97-ca29d1bd3899", "AQAAAAIAAYagAAAAEBrW3PmBnweZL/Nwy920jmiyFtf301/Kt6ni1GcDzeXK7kI0OR1T3U+FWa0276ivLg==", "eecf35ae-75e7-423c-909c-1f70ae29a101", new DateTime(2025, 11, 7, 16, 57, 21, 754, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "40353b90-11a4-44af-b9c3-0f3309fe8176", "AQAAAAIAAYagAAAAEKdBlwcACW5PMSDl42naIiiGYuofqdUonoKicN7yJPZiAvsLB69FP4dmHncEO7H/Aw==", "67605096-95df-434a-bf6d-81cd6c9b29c9", new DateTime(2025, 11, 7, 16, 57, 21, 793, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0fc9d71e-8c59-4580-a7ba-21aa8d0931d8", "AQAAAAIAAYagAAAAEJsyEtUdUpvUz0pb0mNhV/+m3eDJ0MRJT1NifYy1+jIuAB4HfECMsLDI3HicGqn58Q==", "ef425d76-7158-467e-9d8f-b39f034dd918", new DateTime(2025, 11, 7, 16, 57, 21, 834, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "43d172ff-e60a-4e06-9d35-838f42e1c298", "AQAAAAIAAYagAAAAEFJceIOI9EpEqHL/vWPqPly0H3qc6HG1FRdic1CC8kV9P8nh6MFPo78MQnBtYPqpLw==", "d3d4e9ea-4701-4cf4-9bc0-48a475f199e3", new DateTime(2025, 11, 7, 16, 57, 20, 772, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5ae8b0ce-155f-4428-929f-1d1e6d41ae7c", "AQAAAAIAAYagAAAAEJfQWeYu+BmwV7ipkTCZcTfa5wPKxUxheGIAClreRfhxqplW5O1udDU/AzsZPWisLw==", "7242e8fe-8ee7-464d-97b9-b7b39ed98865", new DateTime(2025, 11, 7, 16, 57, 21, 875, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cd67846f-b5eb-43a8-ba46-1b774794abfd", "AQAAAAIAAYagAAAAEFkuqSm/VyzoHIeb8zmYKI6F6uAQF92aLUmOfgovZCOm4Q/NTNwg21puCK/gBM6jjw==", "b8180c03-a4be-4ee8-a360-15fa1c0c1163", new DateTime(2025, 11, 7, 16, 57, 21, 915, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d381606d-1784-4348-84dc-f51e0eb44159", "AQAAAAIAAYagAAAAENG/9bRHgJPOqmTkRhmZVgnr5z9+7/maqUw9B9D6DKH4vFuxoJHMd2vIvvqYaSk96Q==", "7de50ade-18c3-4e87-826a-02962a45bb56", new DateTime(2025, 11, 7, 16, 57, 21, 955, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f08c379b-cdbf-47a1-8db1-7c06e90f8bc5", "AQAAAAIAAYagAAAAEAOvIR4Vb+qlj0uFuueQhEUFJzgDTHKFkeLVchSBKsZTYXaqtnvVyL4+nFcZ+8S/BA==", "97fcd1f5-b447-4d34-a607-9f6e176dd165", new DateTime(2025, 11, 7, 16, 57, 21, 994, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "33148535-d7f5-4437-89e7-3faf9e0597a3", "AQAAAAIAAYagAAAAEDXTVOFHCX3stwlqzj5cU182Jn6TO4Wn9+zTAJn2+vHztMcFXyNvSxC1+Dw/HBO4Mg==", "55015a36-adc7-4fcd-90f7-e85bb7e68400", new DateTime(2025, 11, 7, 16, 57, 22, 34, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "be1a82b3-be15-46dd-88e4-7b6a347daed1", "AQAAAAIAAYagAAAAEJw8a5FTXIajgmrwMaXlSo3KrRo5a3xXjMtpl9lp8uCr++e/nY+JrCj/U1jubQ20Eg==", "f1f84cff-e5ec-4fa5-964e-686503bb568e", new DateTime(2025, 11, 7, 16, 57, 22, 75, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f25a37fa-dd76-40ad-8abb-f9d1888ea0df", "AQAAAAIAAYagAAAAELwMZs5asw1qfuEqGB1lXpmJyyyUnXq1QZ1Cd++lz5De1O47fdkI0Ryx4wL1Nqp1tQ==", "659c079d-b3a5-4a69-ad50-896b5f0de9d4", new DateTime(2025, 11, 7, 16, 57, 22, 114, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "053b3a86-cb1b-4779-b206-1df3c866f749", "AQAAAAIAAYagAAAAEN/GFWeKHU9x0QmMxVY0Qj1XmvoiCULpIFBGspwKXEz2Wwp/GuNIPrx9fcOnz0mkJQ==", "c1348990-bc00-4321-976e-b9679408d231", new DateTime(2025, 11, 7, 16, 57, 22, 155, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0aeb7b79-a28e-4810-b1bb-b83d6700dc79", "AQAAAAIAAYagAAAAEKiD0M/lfAfz5gWT/k8YUjHnzOjIA8x3Z094R5cEeHNcAfhagttwA11OVUa5oWBAyQ==", "c5206843-1d79-4692-8ab8-88ad8c240684", new DateTime(2025, 11, 7, 16, 57, 22, 196, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f94eaf8d-3ebe-48d8-8c2f-2bbd22c2ace1", "AQAAAAIAAYagAAAAEETcjWEHDKW0nNHbBDB9g0JJuL8sbaQ9V+hoOvCjvUv4RV305xqykNdOHp1v+iMROA==", "7f4184b1-b09b-40d7-aa8e-9bc9be2cdd9b", new DateTime(2025, 11, 7, 16, 57, 22, 235, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8c2e84f1-04cf-44f0-85dc-91bf443f583a", "AQAAAAIAAYagAAAAEDXfoWTvwkEzizdbgHxFGx8hHkdFqIrKh/phFt1zAN3lK1JLLiUlLCfyHQNxjpa2aw==", "0fc569cc-b2b6-4ec0-8ad5-4da7817954eb", new DateTime(2025, 11, 7, 16, 57, 20, 812, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c136e05f-205a-4144-ac0c-486157548b49", "AQAAAAIAAYagAAAAEN9z5jgfZ7fuiTsfrZClOKINo1TI6mxGmbyXYZJ28XJq7GPf+1Mbve3q9NXAm0AHoA==", "5dfeb600-8621-406f-b394-241711bd8333", new DateTime(2025, 11, 7, 16, 57, 22, 276, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f95a4dff-2953-453e-bf48-8c7c64ea0b15", "AQAAAAIAAYagAAAAEHdryp+5Wo+dyQFTegLaRW7MDGmkoaCIo9ISpcxPlOnTHDm0Sz6QJSM/TueaXztr9Q==", "8a958098-9470-413b-a03f-b39904b7ac05", new DateTime(2025, 11, 7, 16, 57, 22, 317, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ec9531ab-dac9-4cee-b12a-b148c9226b92", "AQAAAAIAAYagAAAAEEYE2olhkT5gMK2WfyWUVK2Yuzjw830096HD0hU971mdA3+EfHjZ8hVWqf0U7tYe/A==", "567cc627-a898-40f4-a1e8-c4c34e36a872", new DateTime(2025, 11, 7, 16, 57, 22, 356, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f9a15652-fb65-4795-8b4d-a44ee4616d27", "AQAAAAIAAYagAAAAEKL6GqRHt4lS4h4+0UjFPSkEZ+kxJmRzBZ3/Wi4jNWMrMjwLkgkCf/OzaT+icS1g4A==", "3435e618-f9fb-4a4d-ad12-bca64445db13", new DateTime(2025, 11, 7, 16, 57, 22, 395, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7d5adbdf-66ab-48b9-9685-da0b20301cc2", "AQAAAAIAAYagAAAAECRdpVJVLVHAoSlGj2/h59JEagxk0PGH/nke2Fk3Jiy2CIFW6dm7WbzqAySY8auHCw==", "7b445997-f538-4204-b9bb-25179bac1149", new DateTime(2025, 11, 7, 16, 57, 22, 435, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "887de47d-a503-4bd6-86f6-48d138fa77da", "AQAAAAIAAYagAAAAEKEzfjhxAtT26cwYaAQ3rs3J+mZnQuTJZH4BAZHYjvViB95I4pOil26QGqEFoheDbA==", "3600bd9f-190d-4cf6-a3f1-cdc557281163", new DateTime(2025, 11, 7, 16, 57, 22, 475, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "68183926-70f8-462f-bb40-855492b1242b", "AQAAAAIAAYagAAAAEMQueRGCd8Q32oOHS1Q7TJmJNV7e+mKD2ciMJhDYYYiRfRd5IfIyxxk+P3Wr28+4aQ==", "f8f0f7c1-74c3-45d7-9213-977308163a28", new DateTime(2025, 11, 7, 16, 57, 22, 517, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f6a3e140-17bb-4741-954f-ed2bd56f6e22", "AQAAAAIAAYagAAAAENrfQgDvKd1rlQ78FfJuwPAkbjcVF359WiFlD3ii+ZyrBMuP1rMUuY3/GsXQrt5lFg==", "68a9a342-3fc2-4e7b-9ef8-7abcb117d70b", new DateTime(2025, 11, 7, 16, 57, 22, 556, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ca364fa0-2f20-40c7-ac4e-7131d5c9b64a", "AQAAAAIAAYagAAAAEPseH1KCS+UVpPk/VvZEwgYPpLIPDMAizMj++drh/XsKH++2wW7L5XsKZLugS5VYwg==", "a1990e55-6bce-44f4-a337-b9176b2b6992", new DateTime(2025, 11, 7, 16, 57, 22, 597, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "85e98ce3-0e84-4a6e-9bbe-af27878f9ef8", "AQAAAAIAAYagAAAAECBrCV2EyTNv42Qx66b7Kz+nKQHuChYm7hwbzMlR2HAxlzB2X9+OA0LDgDw1hr/GKw==", "87d2240c-b85a-45fc-ad4f-74bc1ec68579", new DateTime(2025, 11, 7, 16, 57, 22, 639, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fb75aa7b-b8a6-4899-ba27-8af6f1c9e623", "AQAAAAIAAYagAAAAECRrP/BxdNhT5m18PjKvwVPiK47FO5EQbaHg4zYevdOuXtcJYXl9BLRHPCcVSMYw3Q==", "21321e51-0f4d-4ebb-b372-71a2175a1b16", new DateTime(2025, 11, 7, 16, 57, 20, 854, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dcc65126-6dfa-4c40-927f-6233942b50cd", "AQAAAAIAAYagAAAAEEkQQLV2jIMC+sI69UybBX4i8mPyO2MlR3xatu2oujm5LQwooByMGEPHbrqoIS5xVQ==", "523062df-bf3c-42e7-acbb-c6c93c1dda60", new DateTime(2025, 11, 7, 16, 57, 22, 680, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0bc9fb2c-fb1e-4ca9-9277-d160ebf8ec12", "AQAAAAIAAYagAAAAEKHAWym4i1y6O+GXyS8b8u9BIFMkUReWIQrcyTPWLth5D4mJS2mz1S3NsaRvLb6Bww==", "4d0e08d1-5795-4b1e-b975-35d461d5a0c9", new DateTime(2025, 11, 7, 16, 57, 20, 896, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d021cbc8-962d-4167-9805-edb675f27360", "AQAAAAIAAYagAAAAEEFgy+hskJ9RHv5czHV4w29J0lMhQjEkH6bzIS0IkPXZ0qkURlYrVSXmOEq1lcQIig==", "280d07cc-979d-473f-8b56-e1ede684161b", new DateTime(2025, 11, 7, 16, 57, 20, 938, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0ad9e519-44a5-4f2a-995f-db9219bf7adb", "AQAAAAIAAYagAAAAEBnvmdUEnbvJ9PTA/96LEHdxZZugp1PNZtzbhg3AD3Mgoqme5xrrrLMHNp8h69Nm6A==", "c7a0e7b8-bef6-46f1-aead-0a76b9ed483f", new DateTime(2025, 11, 7, 16, 57, 20, 981, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3b9ed8ee-b5ae-409a-bc98-5b7c095a920c", "AQAAAAIAAYagAAAAEC8ynLgY1o6MIZTZdRTmbwF6mwfqKdrN/NLTi1L+l0EyTULAuU7GUFJhXKVuIJoxSg==", "45f93beb-98e3-4707-817a-0f03aded4d19", new DateTime(2025, 11, 7, 16, 57, 21, 22, DateTimeKind.Local).AddTicks(7929) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 50L);

            migrationBuilder.AlterColumn<string>(
                name: "LevelName",
                table: "Levels",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1L,
                columns: new[] { "CourseName", "Description", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Demo Course 1", "Mô t? ng?n g?n cho khoá h?c s? 1", 21m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status" },
                values: new object[] { "Demo Course 2", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 2", 22m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Demo Course 3", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 3", 5m, 23m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Demo Course 4", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 4", 0m, 24m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Demo Course 5", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 5", 25m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Demo Course 6", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 6", 5m, 26m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status", "UpdatedAt" },
                values: new object[] { "Demo Course 7", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 7", 27m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Demo Course 8", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 8", 0m, 28m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Demo Course 9", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 9", 5m, 29m, null, 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Demo Course 10", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 10", 30m, null, 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Price", "PublishedAt", "Status", "StudyTime", "UpdatedAt" },
                values: new object[] { "Demo Course 11", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 11", 31m, null, 0, "5 hours", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12L,
                columns: new[] { "CourseName", "CreatedAt", "Description", "Discount", "Price", "PublishedAt", "Status", "UpdatedAt" },
                values: new object[] { "Demo Course 12", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mô t? ng?n g?n cho khoá h?c s? 12", 5m, 32m, null, 0, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 25, 16, 4, 42, 811, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "83068dac-7c2c-417f-b4a7-195fccb01b97", "AQAAAAIAAYagAAAAELSnOyB+WZeW+tKcCCeFOZtq0koWImT1eheD5GFqre54j0ZQFrSMwkg/JjwZZ+wnqA==", "31731aa3-301a-4fd5-957e-4dd3e23728d3", new DateTime(2025, 10, 25, 16, 4, 42, 812, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "eac77b13-d3c6-4253-ab0e-189da7f3557c", "AQAAAAIAAYagAAAAEDIR2KhERdP3r4bNi5GAlFMZKsy/7/gWWtEpV8AcynoNv5fJxk8Syl74EXBRUGcF6w==", "e31abade-0e80-41b0-9c23-ac3be042ddcb", new DateTime(2025, 10, 25, 16, 4, 43, 204, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ed53e7cc-df95-4a2d-bad0-0390d20f36e6", "AQAAAAIAAYagAAAAEOV6nS1QqHLKcdNQO0W9i4ikEbAD5uK//LHjACs7lbP3byB7vRu5x1FIFG6oCR1/DQ==", "da67cb35-de08-4c84-9d7d-41c06ffa1dd1", new DateTime(2025, 10, 25, 16, 4, 43, 247, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "50d6c580-b4af-430a-be8d-c26f6d2dd887", "AQAAAAIAAYagAAAAEO/E2zWe6vXmpz6dVoGrfXji6+EdqI+2GQZTebLlv868V77IuB8NU/oGhNd7z4hKJA==", "50b1f7b0-f258-40de-8bec-f2a4cff5e32f", new DateTime(2025, 10, 25, 16, 4, 43, 289, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0d1c77df-9bd8-40b4-a641-49e70477f94a", "AQAAAAIAAYagAAAAEL2FQxjL9/cBnwETOPaZPAUPuohKbqS4gpEpFQ2URn3sLg0UeSruMUKu205RSpfgsA==", "39cdd548-0b7d-4b96-bb8e-815b93a759c4", new DateTime(2025, 10, 25, 16, 4, 43, 334, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bca447c4-0c61-4a15-b3e7-63bc7328a8c7", "AQAAAAIAAYagAAAAEPWCyAfh5qb/Ag7VPpvTKgn8rSrYPw6swYhMlAdev9tdVxRNCq9/JqN4Nw7JgSoBVQ==", "8f7b9dac-f783-4980-b8c9-d9b829ca30a4", new DateTime(2025, 10, 25, 16, 4, 43, 376, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "461a36f8-6815-492d-82a8-c7904693b074", "AQAAAAIAAYagAAAAEIs+8ShiD8v6cM6ZxTmmPN6jlfzU/nCS2FiokBJxltxsJMHAORm7zyR7tSNHM9ofoQ==", "3bb89101-52ad-4b03-b251-80a30942cb73", new DateTime(2025, 10, 25, 16, 4, 43, 423, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e539471e-36bb-43ff-8810-d0ce8bece4a6", "AQAAAAIAAYagAAAAEJm+AUObXb8YtwrViKMiujRVRuNC5ysmIXh47Hbv+8OYQUHpepIbcKoi0EELVtuz8Q==", "6957c4fe-bdb4-4016-8072-b272aa07e70a", new DateTime(2025, 10, 25, 16, 4, 43, 469, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ad32afc0-77ec-49e9-8a9c-2321fabb8e4f", "AQAAAAIAAYagAAAAEMuDdvD8HFO9aSn3XG7CERETpGIT2EuRpSC+8FO+hEnX+viipZV0BDsh+SjVhVF9yg==", "7a3c8b4b-778f-454f-8bac-43d3f1b279e8", new DateTime(2025, 10, 25, 16, 4, 43, 513, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "aa7e8693-fa70-4ef8-8387-02e72c22ef75", "AQAAAAIAAYagAAAAEG3dD9CnYnRKGBnSnduPw8Mx9qjQ4wIKi57u9F+vb2GuLa/NJNZQlfM8eDhQTRf56Q==", "60653e8d-5309-4239-9205-cf0287674e40", new DateTime(2025, 10, 25, 16, 4, 43, 563, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2629ca32-4b3f-4eb7-bb88-70449f162132", "AQAAAAIAAYagAAAAELksijyMdnTSDBEhs5B0/3xLWiMTszDFS0rYDJdT167FNZuNBPcj31v3izZQuXNCgQ==", "b50fbb7a-7dfe-4bee-9854-6b13e8fc7fbc", new DateTime(2025, 10, 25, 16, 4, 43, 609, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e0d0f51a-4375-4830-984c-19da4399c7cd", "AQAAAAIAAYagAAAAEAjvzRyRPkSuN4T8L5ngPE73iLjbnAub+HSw6HNPjJjA/4sAsv6556CGgEIqr5Yfaw==", "536b923c-0cbb-45ce-a3e3-470039b5bdc0", new DateTime(2025, 10, 25, 16, 4, 42, 857, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "432f394d-0195-4c7e-b20f-be44356a0d8c", "AQAAAAIAAYagAAAAEDrv556+LiiLTrkDgfBLQ8TfNPqgFuEkFH+D0MVLV5kspHRhdOwLDlpJDRX9BRJUmA==", "6067aa1b-30d1-4fdd-89bc-a812a740d20b", new DateTime(2025, 10, 25, 16, 4, 43, 655, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "41357585-b028-487e-926a-43b1048e6ce2", "AQAAAAIAAYagAAAAEPq9DWyislcIfYqykT2ivHZYJEVFGuJIBdMiB5GMuqKirAeYzdqgJ1W81RYneEesTw==", "e6437eec-5946-4f32-85ed-a5c0c9021dbc", new DateTime(2025, 10, 25, 16, 4, 43, 702, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ecaf8a1e-6a2a-48ab-bd81-6cad45d06da4", "AQAAAAIAAYagAAAAEEYLJyYA4O7OuFFWyi6B0nmoV2OQ/Jh2BSpZ+uagkD+r0TbQ7ahCQUMIAfV1g+Z56w==", "707ea91f-f5be-4559-9621-e90ea93a1c81", new DateTime(2025, 10, 25, 16, 4, 43, 747, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f9c305d5-1e4a-4ca2-bb0e-f0b32e090c35", "AQAAAAIAAYagAAAAEAGEtISGyU1ncOD2yKicWNpQREorJrOC9vnf1+MpfeZO0TkW0qACYch31oaCzU1wlw==", "f97ea1a6-1fbf-412c-aa06-5cc60383177d", new DateTime(2025, 10, 25, 16, 4, 43, 797, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "92c53436-72b2-4220-ad9b-dc7441b546d1", "AQAAAAIAAYagAAAAEFEGUs4lZfg6eFrmbI5rR/VgC0Selj5JOsYKOWcm5MLPQcKFC7eWiIdWTGqZM/6InA==", "7c2c7842-448c-4d3f-9dc1-5ca76ecf410f", new DateTime(2025, 10, 25, 16, 4, 43, 842, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4b65b49d-28f7-41b5-88b8-ac692bdf2553", "AQAAAAIAAYagAAAAELSezjmaD71uJ7drux6n+axCTcb1w/ES0zmoL2lROE9MzxKNS1x/ubN44WI8auNwOA==", "7735121d-f5d3-4106-acad-91f41d08ddf0", new DateTime(2025, 10, 25, 16, 4, 43, 888, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "884e559b-9d5c-41e8-82db-a02a6dc8039c", "AQAAAAIAAYagAAAAELxJdVdJVV7pnMajIQ/VwTpzOU9iMnZXrFiBAMuyqlWq5xULT2XwP0ULuh1NIbfDSw==", "2adf5536-69cd-4e47-9be7-243e7d15123e", new DateTime(2025, 10, 25, 16, 4, 43, 934, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "21ddf796-f10e-41eb-8aea-0503436ec185", "AQAAAAIAAYagAAAAENdE1kRLTsm9bwQADfvztO41RuhNoYXyvVXu67eLhagmYzoDVTKkrHidGVrUj7i4Uw==", "f1e7f277-d9aa-4e4e-b69e-45224fa3daa2", new DateTime(2025, 10, 25, 16, 4, 43, 980, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5af67a21-0497-4af9-b488-f3e6e41a63cf", "AQAAAAIAAYagAAAAEEOynSvaUTRIhGblSCqJmzD6y0x9iYmiTUZNwKhFZYTX9+3pv3uqhej3uT+qsRh1DQ==", "f4235345-9081-43f8-9962-2f60e66eefbd", new DateTime(2025, 10, 25, 16, 4, 44, 27, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e0c7978f-1bb1-46ef-8dc3-535cb50a1553", "AQAAAAIAAYagAAAAENZNXiNQxXeuPpaOiDf9/D7EMO4sMkBTOuXwqh5M1XQKP5ZqHM3DaiThKzKhHaGgUA==", "2e89d9a1-fc2a-438a-a3c4-9f5fb6b41cca", new DateTime(2025, 10, 25, 16, 4, 44, 72, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ed1af747-5151-498b-886b-2e0f317d6322", "AQAAAAIAAYagAAAAEOO6R2RsJGAclGYBmCbVxvcq/IizyH9qJrSp9Hi9je/ABkjB9h4SHOFMEdR6GbsltQ==", "7b4768c1-ff65-40e1-8b93-b95e6b57209c", new DateTime(2025, 10, 25, 16, 4, 42, 902, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "65f44d3f-d10d-4ddf-b7cf-af99693b6d5c", "AQAAAAIAAYagAAAAEFSY3BQi0vxgXpStoO3StBUC6M0HHhqZyDcZW7/qlMfmwHHwwV1wrUk2xo/qbNcj0Q==", "a1fb2ce6-2e8d-41c7-8172-9ff4396babaa", new DateTime(2025, 10, 25, 16, 4, 44, 119, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8521b52f-ad7c-41d2-b08e-b4a8068714cf", "AQAAAAIAAYagAAAAECZB4EiHaPGWKb5KKrKDGhnCJxTsH55mhCSbHOfTBXS87VsPUTXGolM7NLTeTY5wdQ==", "f4033131-d8d2-4e97-991c-b6d6bc7e84c7", new DateTime(2025, 10, 25, 16, 4, 44, 166, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ef0127a7-831e-411d-9b6e-4b93d91fe0f8", "AQAAAAIAAYagAAAAEPONnvmLkM/5lsC2tsyU5zhQ4JAwiA4vKJcjmVVI8mRZLqOPftpn8hyBR6hGustadQ==", "68f1b355-0e6e-4310-9fe2-f20142b19139", new DateTime(2025, 10, 25, 16, 4, 44, 211, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "999a1967-e361-4d72-b5da-9e4a08313cb3", "AQAAAAIAAYagAAAAEMrsruZveaWo17EDUHcwobAeQSGM1Gsb9NyPQH6Lk2x4p9I/Z2fesPIbZC/WZiOaOQ==", "8d2f08e6-73b0-40e2-953a-1e818a6a6fa2", new DateTime(2025, 10, 25, 16, 4, 44, 259, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1850ef80-48b4-459b-b7b2-b08522b897fa", "AQAAAAIAAYagAAAAEL70JraqmXl46tgQdIZwiCtQ83U/dRB9vAzqAIFweJP+g8d8Spv3fI/1Mvwo1WqwZQ==", "4f7f01cc-e260-4382-82bb-2e4dd7fe34e2", new DateTime(2025, 10, 25, 16, 4, 44, 306, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "593dc753-3a7b-4069-903d-7dcf4343834e", "AQAAAAIAAYagAAAAEC0xhfMqMqlsD2noABWXWgYD7s850DL/RvSAHc8X0pAOthq/nbweiiaD6lkxzVMMuQ==", "ddc8b64c-487d-443e-8986-dc8a7d0b1b13", new DateTime(2025, 10, 25, 16, 4, 44, 351, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "82c4d602-3255-4d26-b19d-839ad3f30a55", "AQAAAAIAAYagAAAAEPfVLh3rl/FjYe/22oew3LXkYmoESnd3/3YENHB39yp47FyLIqRWahoFSURVjqBWRg==", "70143c2a-0c19-4962-bbf0-8d730f6d60f3", new DateTime(2025, 10, 25, 16, 4, 44, 396, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ad87b8bd-df5a-43a0-b4c1-43dc7958346c", "AQAAAAIAAYagAAAAEF3RRSZzaP85OdaKtTEPGG1po6qW3GzZndPqKXJjvpYk5X6z3m5utPyqwLDg0+JZlw==", "a2076744-804a-4cd7-b70d-43bad8b17c7a", new DateTime(2025, 10, 25, 16, 4, 44, 442, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ae75adf2-651b-4593-b76c-5b774f51e8c1", "AQAAAAIAAYagAAAAEO1CZEkzBNjk9S+lTNAJxyoSJsJark0PcglLsiLGe8RtFbqX9+RTIqvQEgkRriQuLQ==", "ef35ab62-b1e3-4e0e-9177-ae7a5b5dfc56", new DateTime(2025, 10, 25, 16, 4, 44, 487, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f9d9a712-f3ee-47d4-a2d1-f421d40a2977", "AQAAAAIAAYagAAAAEAxuJEHZdZymo1Zu8gT1lwY/WV4EVcCzywRkk+1FiG5NyOxmMDOzNbThIQ0eeYyCDQ==", "7bf9e99d-aabf-405e-88f6-4714fe6619fa", new DateTime(2025, 10, 25, 16, 4, 44, 534, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0e1c1748-8a94-4cbb-aab6-00b4e0631540", "AQAAAAIAAYagAAAAELrtlJHKcbqHyAXvdEC+q95dJ5G3TCISlFa4gghkGjHyeuZx2gJn/9innULe22frXg==", "9e92e14c-81ab-41d5-ab92-dc200c90fadc", new DateTime(2025, 10, 25, 16, 4, 42, 947, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "95b7277c-8a04-4ccd-b9df-ad80340e2a3a", "AQAAAAIAAYagAAAAEJZVloFOxefvpCSnXsrZuldXDJYYdupAqBuPnZkwfBYaTF/+i2HHPID4o386jlyoBg==", "f1ac36b2-f2a8-4df0-b8a5-d30e38254116", new DateTime(2025, 10, 25, 16, 4, 44, 581, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9628cb6c-f85f-4911-956a-194bccdb1948", "AQAAAAIAAYagAAAAEMZ1zUVAKeHagHT01lZe6CmnzGneYeZwQBA6SWzCjB0yYxiUbdFuzBlQAMphpF9yGA==", "335c4cd6-2607-4db0-94aa-5388ec34ab6e", new DateTime(2025, 10, 25, 16, 4, 44, 627, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f02dfad3-e11f-4094-8353-6112c0387512", "AQAAAAIAAYagAAAAEK3WHaAXipyu4+3n1/xgbQiSOJZdLFwCa68d9XV0/yjolLTpmkxOduqo5ztUeHSUvA==", "82747a94-804e-424a-9330-ab3067a4049d", new DateTime(2025, 10, 25, 16, 4, 44, 673, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "251c5d3d-12ca-421a-8783-3c39544a2f92", "AQAAAAIAAYagAAAAEH5ffupmlMzM/pw87WbhaAdSJdeM7ELV51T27tFHJxQs8uU2aACKauWBVBe08bIOUw==", "bfb75c8e-819e-444f-af11-65fad5984db7", new DateTime(2025, 10, 25, 16, 4, 44, 718, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "17dd36c4-dba4-4aba-9d1d-127807f79506", "AQAAAAIAAYagAAAAEBdawvUuSjC7hUX9Os2QULsR1bJ7/crKv1omxhq4r1/dL1g0K4zXHO4BpshZ1nZj/w==", "02801b87-6108-4c7b-8b8c-9fdac3b05a03", new DateTime(2025, 10, 25, 16, 4, 44, 763, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "30c36d2c-1c72-48ef-a59d-a0c0596f2ebd", "AQAAAAIAAYagAAAAEHYvgMOMrMXHRnAt6FJUyvj1Ad9baBIaALAqUmQkqT3al3PERy3kNrvrer8d2l775A==", "c830605c-c8f4-4d62-8272-65646d238c65", new DateTime(2025, 10, 25, 16, 4, 44, 811, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7097ce12-c1d6-4f34-89db-863bbecd9067", "AQAAAAIAAYagAAAAEAHT2kYgpg9FV7S5n5lD06itIWFUiG3Vc3MguITe2gzkcSMEo7FLz28xPpgKaE5j0Q==", "114f1c78-4559-432b-93ea-56fd1a67ecbf", new DateTime(2025, 10, 25, 16, 4, 44, 855, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c19310d7-5425-48be-b4d5-fa217a2527ad", "AQAAAAIAAYagAAAAENX6/8RJWvU1Cf791oWc/6tiEyg33qsp/BkjN25uLc7wp+RZ1Acj7PYqdrzd0KRDWg==", "b5a9eb53-bc75-4099-bca7-16a581099ba1", new DateTime(2025, 10, 25, 16, 4, 44, 901, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ec82b8c6-1b5c-45e5-b08c-f795c0c3ba62", "AQAAAAIAAYagAAAAEFCl2W381p4/GP0R9BH7lCAL55T1j//WMG52B/wsgB0KFZgqlVHgXHFkZIQ27BR8RA==", "df59290a-5c14-4176-8c05-1276e1326e11", new DateTime(2025, 10, 25, 16, 4, 44, 946, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "922bebf7-b761-414e-915c-f67bb1a49da2", "AQAAAAIAAYagAAAAEK3i2eFDf6+lhOJv8m0pL++nk5/g6TucnNr6I6BX02qlU0YpLaAQrhJVYaqHElKmqg==", "d40d8e0d-e9e7-40d9-bf78-4c78d7d0c5b4", new DateTime(2025, 10, 25, 16, 4, 44, 992, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1c156037-70a5-4ca9-95a2-f85b6b94821f", "AQAAAAIAAYagAAAAEBIX2F09RaFurax943StWycsoelQPa3E1wpJc2vP3vx9zIDOSWZ3FThH2050Eo6qHA==", "b7c4aa36-c11e-4113-b4a2-61eff7de492c", new DateTime(2025, 10, 25, 16, 4, 42, 994, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bf5dfaa0-2174-4e52-9822-efaec559e607", "AQAAAAIAAYagAAAAEJDrgMfJ4FrxHM2D26oN+dc0Wt70aEtlLy8+L5KUbSQPyMrBq5KEa80e72myfj3F9g==", "3445f11a-3c54-48a4-a7d1-b55e1c6abd9c", new DateTime(2025, 10, 25, 16, 4, 45, 37, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1bcfe99e-5f9f-4e33-8b3a-fd31385e50b2", "AQAAAAIAAYagAAAAEFPlGIQaGI+4BLUHouQvws7o/+6B0I8PYW8EJkxjXjCfhcm+Izftzv5ictH6Qo+LAQ==", "9e272f37-e0f2-4397-8552-f8175cee1a58", new DateTime(2025, 10, 25, 16, 4, 43, 37, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "69eb04b7-d568-441a-88a5-7f14d0f3b767", "AQAAAAIAAYagAAAAEBR0EkGL9hmQQr/EjHqcOvIiTiacdP+0/BQTf2Z5L/1gHkmAYcT5TQxjN3Zd3DKp/w==", "8ede2c2c-14f3-4181-9ba7-d9ca5662115a", new DateTime(2025, 10, 25, 16, 4, 43, 79, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "347dd261-9883-4197-8c04-3695531c9409", "AQAAAAIAAYagAAAAEIpLKCAeO43x42ZUE6SUXHpQ2BrgjLkzmoFudNlAxhL9zV78LgICFTNoevIjdhglIg==", "88490fc3-b15c-41d0-a1ee-436ea903c081", new DateTime(2025, 10, 25, 16, 4, 43, 120, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "712b7989-f4f0-4b8f-9762-b767d827f803", "AQAAAAIAAYagAAAAEAmZHMWWtcG2S5q9vLfdA6biWhTbe+1DpLa0qEWpIDusdJ9CncFOYeERVU3Ud/ri9w==", "24578079-bf53-45e1-9014-98f660f0aa1d", new DateTime(2025, 10, 25, 16, 4, 43, 162, DateTimeKind.Local).AddTicks(1382) });
        }
    }
}
