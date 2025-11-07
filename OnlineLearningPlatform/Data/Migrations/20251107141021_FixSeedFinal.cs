using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "3" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "4" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "3" });

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
                keyValues: new object[] { 5L, "3" });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 2L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Approved for publishing", 0 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 4L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Approved for publishing", 0 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 6L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Approved for publishing", 0 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 8L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Approved for publishing", 0 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 10L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Approved for publishing", 0 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 12L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Approved for publishing", 0 });

            migrationBuilder.InsertData(
                table: "AdminReviewCourses",
                columns: new[] { "ReviewId", "AdminId", "CourseId", "ReviewNotes", "ReviewedAt", "Status" },
                values: new object[,]
                {
                    { 13L, "1", 13L, "Approved for publishing", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14L, "1", 14L, "Approved for publishing", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15L, "1", 15L, "Approved for publishing", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 16L, "1", 16L, "Approved for publishing", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 17L, "1", 17L, "Approved for publishing", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 18L, "1", 18L, "Approved for publishing", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 19L, "1", 19L, "Approved for publishing", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 20L, "1", 20L, "Approved for publishing", new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 21L, "1", 21L, "Approved for publishing", new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 22L, "1", 22L, "Approved for publishing", new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 23L, "1", 23L, "Approved for publishing", new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 24L, "1", 24L, "Approved for publishing", new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 25L, "1", 25L, "Approved for publishing", new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 26L, "1", 26L, "Approved for publishing", new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 27L, "1", 27L, "Approved for publishing", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 28L, "1", 28L, "Approved for publishing", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 29L, "1", 29L, "Approved for publishing", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 30L, "1", 30L, "Approved for publishing", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 31L, "1", 31L, "Approved for publishing", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 32L, "1", 32L, "Approved for publishing", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 33L, "1", 33L, "Approved for publishing", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 34L, "1", 34L, "Approved for publishing", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 35L, "1", 35L, "Approved for publishing", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 36L, "1", 36L, "Approved for publishing", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 37L, "1", 37L, "Approved for publishing", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 38L, "1", 38L, "Approved for publishing", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 39L, "1", 39L, "Approved for publishing", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 40L, "1", 40L, "Approved for publishing", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 41L, "1", 41L, "Approved for publishing", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 42L, "1", 42L, "Approved for publishing", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 43L, "1", 43L, "Approved for publishing", new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 44L, "1", 44L, "Approved for publishing", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 45L, "1", 45L, "Approved for publishing", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 46L, "1", 46L, "Approved for publishing", new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 47L, "1", 47L, "Approved for publishing", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 48L, "1", 48L, "Approved for publishing", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 49L, "1", 49L, "Approved for publishing", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 50L, "1", 50L, "Approved for publishing", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 1L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 2L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 1L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 3L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 5L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 4L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 5L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 5L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 9L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 6L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 9L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 7L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 13L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 8L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 14L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 9L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 18L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 10L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 18L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 11L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 21L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 12L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 21L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 13L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 25L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 14L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 25L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 15L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 29L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 16L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 29L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 17L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 33L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 18L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 34L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 19L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 38L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 20L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 38L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 21L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 41L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 22L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 41L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 23L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 45L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 24L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 45L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 25L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 49L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 26L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 49L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 27L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 53L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 28L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 54L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 29L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 58L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 30L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 58L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 31L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 61L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 32L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 61L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 33L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 65L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 34L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 65L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 35L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 69L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 36L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 69L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 37L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 73L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 38L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 74L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 39L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 78L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 40L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 78L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 41L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 81L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 42L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 81L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 43L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 85L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 44L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 85L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 45L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 89L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 46L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 89L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 47L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 93L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 48L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 94L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 49L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 98L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 50L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 98L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 51L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 101L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 52L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 101L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 53L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 105L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 54L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 105L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 55L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 109L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 56L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 109L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 57L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 113L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 58L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 114L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 59L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 118L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 60L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 118L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 61L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 121L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 62L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 121L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 63L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 125L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 64L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 125L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 65L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 129L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 66L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 129L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 67L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 133L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 68L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 134L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 69L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 138L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 70L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 138L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 71L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 141L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 72L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 141L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 73L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 145L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 74L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 145L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 75L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 149L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 76L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 149L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 77L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 153L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 78L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 154L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 79L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 158L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 80L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 158L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 81L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 161L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 82L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 161L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 83L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 165L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 84L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 165L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 85L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 169L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 86L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 169L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 87L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 173L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 88L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 174L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 89L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 178L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 90L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 178L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 91L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 181L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 92L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 181L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 93L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 185L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 94L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 185L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 95L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 189L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 96L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 189L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 97L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 193L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 98L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 194L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 99L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 198L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 100L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 198L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 101L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 201L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 102L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 201L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 103L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 205L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 104L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 205L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 105L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 209L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 106L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 209L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 107L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 213L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 108L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 214L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 109L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 218L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 110L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 218L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 111L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 221L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 112L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 221L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 113L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 225L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 114L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 225L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 115L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 229L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 116L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 229L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 117L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 233L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 118L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 234L, "6" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 119L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 238L, "5" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 120L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 238L, "6" });

            migrationBuilder.InsertData(
                table: "AnswerQuizzes",
                columns: new[] { "AnswerQuizId", "DateCreated", "IsCorrect", "ModifiedDate", "OptionId", "QuestionId", "UserId" },
                values: new object[,]
                {
                    { 121L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 241L, 61L, "5" },
                    { 122L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 241L, 61L, "6" },
                    { 123L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 245L, 62L, "5" },
                    { 124L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 245L, 62L, "6" },
                    { 125L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 249L, 63L, "5" },
                    { 126L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 249L, 63L, "6" },
                    { 127L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 253L, 64L, "5" },
                    { 128L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 254L, 64L, "6" },
                    { 129L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 258L, 65L, "5" },
                    { 130L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 258L, 65L, "6" },
                    { 131L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 261L, 66L, "5" },
                    { 132L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 261L, 66L, "6" },
                    { 133L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 265L, 67L, "5" },
                    { 134L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 265L, 67L, "6" },
                    { 135L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 269L, 68L, "5" },
                    { 136L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 269L, 68L, "6" },
                    { 137L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 273L, 69L, "5" },
                    { 138L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 274L, 69L, "6" },
                    { 139L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 278L, 70L, "5" },
                    { 140L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 278L, 70L, "6" },
                    { 141L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 281L, 71L, "5" },
                    { 142L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 281L, 71L, "6" },
                    { 143L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 285L, 72L, "5" },
                    { 144L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 285L, 72L, "6" },
                    { 145L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 289L, 73L, "5" },
                    { 146L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 289L, 73L, "6" },
                    { 147L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 293L, 74L, "5" },
                    { 148L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 294L, 74L, "6" },
                    { 149L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 298L, 75L, "5" },
                    { 150L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 298L, 75L, "6" },
                    { 151L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 301L, 76L, "5" },
                    { 152L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 301L, 76L, "6" },
                    { 153L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 305L, 77L, "5" },
                    { 154L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 305L, 77L, "6" },
                    { 155L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 309L, 78L, "5" },
                    { 156L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 309L, 78L, "6" },
                    { 157L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 313L, 79L, "5" },
                    { 158L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 314L, 79L, "6" },
                    { 159L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 318L, 80L, "5" },
                    { 160L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 318L, 80L, "6" },
                    { 161L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 321L, 81L, "5" },
                    { 162L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 321L, 81L, "6" },
                    { 163L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 325L, 82L, "5" },
                    { 164L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 325L, 82L, "6" },
                    { 165L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 329L, 83L, "5" },
                    { 166L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 329L, 83L, "6" },
                    { 167L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 333L, 84L, "5" },
                    { 168L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 334L, 84L, "6" },
                    { 169L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 338L, 85L, "5" },
                    { 170L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 338L, 85L, "6" },
                    { 171L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 341L, 86L, "5" },
                    { 172L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 341L, 86L, "6" },
                    { 173L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 345L, 87L, "5" },
                    { 174L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 345L, 87L, "6" },
                    { 175L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 349L, 88L, "5" },
                    { 176L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 349L, 88L, "6" },
                    { 177L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 353L, 89L, "5" },
                    { 178L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 354L, 89L, "6" },
                    { 179L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 358L, 90L, "5" },
                    { 180L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 358L, 90L, "6" },
                    { 181L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 361L, 91L, "5" },
                    { 182L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 361L, 91L, "6" },
                    { 183L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 365L, 92L, "5" },
                    { 184L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 365L, 92L, "6" },
                    { 185L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 369L, 93L, "5" },
                    { 186L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 369L, 93L, "6" },
                    { 187L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 373L, 94L, "5" },
                    { 188L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 374L, 94L, "6" },
                    { 189L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 378L, 95L, "5" },
                    { 190L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 378L, 95L, "6" },
                    { 191L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 381L, 96L, "5" },
                    { 192L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 381L, 96L, "6" },
                    { 193L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 385L, 97L, "5" },
                    { 194L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 385L, 97L, "6" },
                    { 195L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 389L, 98L, "5" },
                    { 196L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 389L, 98L, "6" },
                    { 197L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 393L, 99L, "5" },
                    { 198L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 394L, 99L, "6" },
                    { 199L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 398L, 100L, "5" },
                    { 200L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 398L, 100L, "6" },
                    { 201L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 401L, 101L, "5" },
                    { 202L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 401L, 101L, "6" },
                    { 203L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 405L, 102L, "5" },
                    { 204L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 405L, 102L, "6" },
                    { 205L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 409L, 103L, "5" },
                    { 206L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 409L, 103L, "6" },
                    { 207L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 413L, 104L, "5" },
                    { 208L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 414L, 104L, "6" },
                    { 209L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 418L, 105L, "5" },
                    { 210L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 418L, 105L, "6" },
                    { 211L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 421L, 106L, "5" },
                    { 212L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 421L, 106L, "6" },
                    { 213L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 425L, 107L, "5" },
                    { 214L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 425L, 107L, "6" },
                    { 215L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 429L, 108L, "5" },
                    { 216L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 429L, 108L, "6" },
                    { 217L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 433L, 109L, "5" },
                    { 218L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 434L, 109L, "6" },
                    { 219L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 438L, 110L, "5" },
                    { 220L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 438L, 110L, "6" },
                    { 221L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 441L, 111L, "5" },
                    { 222L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 441L, 111L, "6" },
                    { 223L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 445L, 112L, "5" },
                    { 224L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 445L, 112L, "6" },
                    { 225L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 449L, 113L, "5" },
                    { 226L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 449L, 113L, "6" },
                    { 227L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 453L, 114L, "5" },
                    { 228L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 454L, 114L, "6" },
                    { 229L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 458L, 115L, "5" },
                    { 230L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 458L, 115L, "6" },
                    { 231L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 461L, 116L, "5" },
                    { 232L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 461L, 116L, "6" },
                    { 233L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 465L, 117L, "5" },
                    { 234L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 465L, 117L, "6" },
                    { 235L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 469L, 118L, "5" },
                    { 236L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 469L, 118L, "6" },
                    { 237L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 473L, 119L, "5" },
                    { 238L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 474L, 119L, "6" },
                    { 239L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 478L, 120L, "5" },
                    { 240L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 478L, 120L, "6" },
                    { 241L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 481L, 121L, "5" },
                    { 242L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 481L, 121L, "6" },
                    { 243L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 485L, 122L, "5" },
                    { 244L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 485L, 122L, "6" },
                    { 245L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 489L, 123L, "5" },
                    { 246L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 489L, 123L, "6" },
                    { 247L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 493L, 124L, "5" },
                    { 248L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 494L, 124L, "6" },
                    { 249L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 498L, 125L, "5" },
                    { 250L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 498L, 125L, "6" },
                    { 251L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 501L, 126L, "5" },
                    { 252L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 501L, 126L, "6" },
                    { 253L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 505L, 127L, "5" },
                    { 254L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 505L, 127L, "6" },
                    { 255L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 509L, 128L, "5" },
                    { 256L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 509L, 128L, "6" },
                    { 257L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 513L, 129L, "5" },
                    { 258L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 514L, 129L, "6" },
                    { 259L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 518L, 130L, "5" },
                    { 260L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 518L, 130L, "6" },
                    { 261L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 521L, 131L, "5" },
                    { 262L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 521L, 131L, "6" },
                    { 263L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 525L, 132L, "5" },
                    { 264L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 525L, 132L, "6" },
                    { 265L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 529L, 133L, "5" },
                    { 266L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 529L, 133L, "6" },
                    { 267L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 533L, 134L, "5" },
                    { 268L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 534L, 134L, "6" },
                    { 269L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 538L, 135L, "5" },
                    { 270L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 538L, 135L, "6" },
                    { 271L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 541L, 136L, "5" },
                    { 272L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 541L, 136L, "6" },
                    { 273L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 545L, 137L, "5" },
                    { 274L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 545L, 137L, "6" },
                    { 275L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 549L, 138L, "5" },
                    { 276L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 549L, 138L, "6" },
                    { 277L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 553L, 139L, "5" },
                    { 278L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 554L, 139L, "6" },
                    { 279L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 558L, 140L, "5" },
                    { 280L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 558L, 140L, "6" },
                    { 281L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 561L, 141L, "5" },
                    { 282L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 561L, 141L, "6" },
                    { 283L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 565L, 142L, "5" },
                    { 284L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 565L, 142L, "6" },
                    { 285L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 569L, 143L, "5" },
                    { 286L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 569L, 143L, "6" },
                    { 287L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 573L, 144L, "5" },
                    { 288L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 574L, 144L, "6" },
                    { 289L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 578L, 145L, "5" },
                    { 290L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 578L, 145L, "6" },
                    { 291L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 581L, 146L, "5" },
                    { 292L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 581L, 146L, "6" },
                    { 293L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 585L, 147L, "5" },
                    { 294L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 585L, 147L, "6" },
                    { 295L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 589L, 148L, "5" },
                    { 296L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 589L, 148L, "6" },
                    { 297L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 593L, 149L, "5" },
                    { 298L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 594L, 149L, "6" },
                    { 299L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 598L, 150L, "5" },
                    { 300L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 598L, 150L, "6" },
                    { 301L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 601L, 151L, "5" },
                    { 302L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 601L, 151L, "6" },
                    { 303L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 605L, 152L, "5" },
                    { 304L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 605L, 152L, "6" },
                    { 305L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 609L, 153L, "5" },
                    { 306L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 609L, 153L, "6" },
                    { 307L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 613L, 154L, "5" },
                    { 308L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 614L, 154L, "6" },
                    { 309L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 618L, 155L, "5" },
                    { 310L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 618L, 155L, "6" },
                    { 311L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 621L, 156L, "5" },
                    { 312L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 621L, 156L, "6" },
                    { 313L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 625L, 157L, "5" },
                    { 314L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 625L, 157L, "6" },
                    { 315L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 629L, 158L, "5" },
                    { 316L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 629L, 158L, "6" },
                    { 317L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 633L, 159L, "5" },
                    { 318L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 634L, 159L, "6" },
                    { 319L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 638L, 160L, "5" },
                    { 320L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 638L, 160L, "6" },
                    { 321L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 641L, 161L, "5" },
                    { 322L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 641L, 161L, "6" },
                    { 323L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 645L, 162L, "5" },
                    { 324L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 645L, 162L, "6" },
                    { 325L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 649L, 163L, "5" },
                    { 326L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 649L, 163L, "6" },
                    { 327L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 653L, 164L, "5" },
                    { 328L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 654L, 164L, "6" },
                    { 329L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 658L, 165L, "5" },
                    { 330L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 658L, 165L, "6" },
                    { 331L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 661L, 166L, "5" },
                    { 332L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 661L, 166L, "6" },
                    { 333L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 665L, 167L, "5" },
                    { 334L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 665L, 167L, "6" },
                    { 335L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 669L, 168L, "5" },
                    { 336L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 669L, 168L, "6" },
                    { 337L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 673L, 169L, "5" },
                    { 338L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 674L, 169L, "6" },
                    { 339L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 678L, 170L, "5" },
                    { 340L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 678L, 170L, "6" },
                    { 341L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 681L, 171L, "5" },
                    { 342L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 681L, 171L, "6" },
                    { 343L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 685L, 172L, "5" },
                    { 344L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 685L, 172L, "6" },
                    { 345L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 689L, 173L, "5" },
                    { 346L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 689L, 173L, "6" },
                    { 347L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 693L, 174L, "5" },
                    { 348L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 694L, 174L, "6" },
                    { 349L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 698L, 175L, "5" },
                    { 350L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 698L, 175L, "6" },
                    { 351L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 701L, 176L, "5" },
                    { 352L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 701L, 176L, "6" },
                    { 353L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 705L, 177L, "5" },
                    { 354L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 705L, 177L, "6" },
                    { 355L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 709L, 178L, "5" },
                    { 356L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 709L, 178L, "6" },
                    { 357L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 713L, 179L, "5" },
                    { 358L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 714L, 179L, "6" },
                    { 359L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 718L, 180L, "5" },
                    { 360L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 718L, 180L, "6" },
                    { 361L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 721L, 181L, "5" },
                    { 362L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 721L, 181L, "6" },
                    { 363L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 725L, 182L, "5" },
                    { 364L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 725L, 182L, "6" },
                    { 365L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 729L, 183L, "5" },
                    { 366L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 729L, 183L, "6" },
                    { 367L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 733L, 184L, "5" },
                    { 368L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 734L, 184L, "6" },
                    { 369L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 738L, 185L, "5" },
                    { 370L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 738L, 185L, "6" },
                    { 371L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 741L, 186L, "5" },
                    { 372L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 741L, 186L, "6" },
                    { 373L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 745L, 187L, "5" },
                    { 374L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 745L, 187L, "6" },
                    { 375L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 749L, 188L, "5" },
                    { 376L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 749L, 188L, "6" },
                    { 377L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 753L, 189L, "5" },
                    { 378L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 754L, 189L, "6" },
                    { 379L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 758L, 190L, "5" },
                    { 380L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 758L, 190L, "6" },
                    { 381L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 761L, 191L, "5" },
                    { 382L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 761L, 191L, "6" },
                    { 383L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 765L, 192L, "5" },
                    { 384L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 765L, 192L, "6" },
                    { 385L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 769L, 193L, "5" },
                    { 386L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 769L, 193L, "6" },
                    { 387L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 773L, 194L, "5" },
                    { 388L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 774L, 194L, "6" },
                    { 389L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 778L, 195L, "5" },
                    { 390L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 778L, 195L, "6" },
                    { 391L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 781L, 196L, "5" },
                    { 392L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 781L, 196L, "6" },
                    { 393L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 785L, 197L, "5" },
                    { 394L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 785L, 197L, "6" },
                    { 395L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 789L, 198L, "5" },
                    { 396L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 789L, 198L, "6" },
                    { 397L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 793L, 199L, "5" },
                    { 398L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 794L, 199L, "6" },
                    { 399L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 798L, 200L, "5" },
                    { 400L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 798L, 200L, "6" },
                    { 401L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 801L, 201L, "5" },
                    { 402L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 801L, 201L, "6" },
                    { 403L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 805L, 202L, "5" },
                    { 404L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 805L, 202L, "6" },
                    { 405L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 809L, 203L, "5" },
                    { 406L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 809L, 203L, "6" },
                    { 407L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 813L, 204L, "5" },
                    { 408L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 814L, 204L, "6" },
                    { 409L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 818L, 205L, "5" },
                    { 410L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 818L, 205L, "6" },
                    { 411L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 821L, 206L, "5" },
                    { 412L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 821L, 206L, "6" },
                    { 413L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 825L, 207L, "5" },
                    { 414L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 825L, 207L, "6" },
                    { 415L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 829L, 208L, "5" },
                    { 416L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 829L, 208L, "6" },
                    { 417L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 833L, 209L, "5" },
                    { 418L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 834L, 209L, "6" },
                    { 419L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 838L, 210L, "5" },
                    { 420L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 838L, 210L, "6" },
                    { 421L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 841L, 211L, "5" },
                    { 422L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 841L, 211L, "6" },
                    { 423L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 845L, 212L, "5" },
                    { 424L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 845L, 212L, "6" },
                    { 425L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 849L, 213L, "5" },
                    { 426L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 849L, 213L, "6" },
                    { 427L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 853L, 214L, "5" },
                    { 428L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 854L, 214L, "6" },
                    { 429L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 858L, 215L, "5" },
                    { 430L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 858L, 215L, "6" },
                    { 431L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 861L, 216L, "5" },
                    { 432L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 861L, 216L, "6" },
                    { 433L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 865L, 217L, "5" },
                    { 434L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 865L, 217L, "6" },
                    { 435L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 869L, 218L, "5" },
                    { 436L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 869L, 218L, "6" },
                    { 437L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 873L, 219L, "5" },
                    { 438L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 874L, 219L, "6" },
                    { 439L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 878L, 220L, "5" },
                    { 440L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 878L, 220L, "6" },
                    { 441L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 881L, 221L, "5" },
                    { 442L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 881L, 221L, "6" },
                    { 443L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 885L, 222L, "5" },
                    { 444L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 885L, 222L, "6" },
                    { 445L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 889L, 223L, "5" },
                    { 446L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 889L, 223L, "6" },
                    { 447L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 893L, 224L, "5" },
                    { 448L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 894L, 224L, "6" },
                    { 449L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 898L, 225L, "5" },
                    { 450L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 898L, 225L, "6" },
                    { 451L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 901L, 226L, "5" },
                    { 452L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 901L, 226L, "6" },
                    { 453L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 905L, 227L, "5" },
                    { 454L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 905L, 227L, "6" },
                    { 455L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 909L, 228L, "5" },
                    { 456L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 909L, 228L, "6" },
                    { 457L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 913L, 229L, "5" },
                    { 458L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 914L, 229L, "6" },
                    { 459L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 918L, 230L, "5" },
                    { 460L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 918L, 230L, "6" },
                    { 461L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 921L, 231L, "5" },
                    { 462L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 921L, 231L, "6" },
                    { 463L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 925L, 232L, "5" },
                    { 464L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 925L, 232L, "6" },
                    { 465L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 929L, 233L, "5" },
                    { 466L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 929L, 233L, "6" },
                    { 467L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 933L, 234L, "5" },
                    { 468L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 934L, 234L, "6" },
                    { 469L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 938L, 235L, "5" },
                    { 470L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 938L, 235L, "6" },
                    { 471L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 941L, 236L, "5" },
                    { 472L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 941L, 236L, "6" },
                    { 473L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 945L, 237L, "5" },
                    { 474L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 945L, 237L, "6" },
                    { 475L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 949L, 238L, "5" },
                    { 476L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 949L, 238L, "6" },
                    { 477L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 953L, 239L, "5" },
                    { 478L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 954L, 239L, "6" },
                    { 479L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 958L, 240L, "5" },
                    { 480L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 958L, 240L, "6" },
                    { 481L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 961L, 241L, "5" },
                    { 482L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 961L, 241L, "6" },
                    { 483L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 965L, 242L, "5" },
                    { 484L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 965L, 242L, "6" },
                    { 485L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 969L, 243L, "5" },
                    { 486L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 969L, 243L, "6" },
                    { 487L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 973L, 244L, "5" },
                    { 488L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 974L, 244L, "6" },
                    { 489L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 978L, 245L, "5" },
                    { 490L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 978L, 245L, "6" },
                    { 491L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 981L, 246L, "5" },
                    { 492L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 981L, 246L, "6" },
                    { 493L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 985L, 247L, "5" },
                    { 494L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 985L, 247L, "6" },
                    { 495L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 989L, 248L, "5" },
                    { 496L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 989L, 248L, "6" },
                    { 497L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 993L, 249L, "5" },
                    { 498L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 994L, 249L, "6" },
                    { 499L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 998L, 250L, "5" },
                    { 500L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 998L, 250L, "6" },
                    { 501L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1001L, 251L, "5" },
                    { 502L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1001L, 251L, "6" },
                    { 503L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1005L, 252L, "5" },
                    { 504L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1005L, 252L, "6" },
                    { 505L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1009L, 253L, "5" },
                    { 506L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1009L, 253L, "6" },
                    { 507L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1013L, 254L, "5" },
                    { 508L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1014L, 254L, "6" },
                    { 509L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1018L, 255L, "5" },
                    { 510L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1018L, 255L, "6" },
                    { 511L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1021L, 256L, "5" },
                    { 512L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1021L, 256L, "6" },
                    { 513L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1025L, 257L, "5" },
                    { 514L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1025L, 257L, "6" },
                    { 515L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1029L, 258L, "5" },
                    { 516L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1029L, 258L, "6" },
                    { 517L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1033L, 259L, "5" },
                    { 518L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1034L, 259L, "6" },
                    { 519L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1038L, 260L, "5" },
                    { 520L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1038L, 260L, "6" },
                    { 521L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1041L, 261L, "5" },
                    { 522L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1041L, 261L, "6" },
                    { 523L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1045L, 262L, "5" },
                    { 524L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1045L, 262L, "6" },
                    { 525L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1049L, 263L, "5" },
                    { 526L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1049L, 263L, "6" },
                    { 527L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1053L, 264L, "5" },
                    { 528L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1054L, 264L, "6" },
                    { 529L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1058L, 265L, "5" },
                    { 530L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1058L, 265L, "6" },
                    { 531L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1061L, 266L, "5" },
                    { 532L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1061L, 266L, "6" },
                    { 533L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1065L, 267L, "5" },
                    { 534L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1065L, 267L, "6" },
                    { 535L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1069L, 268L, "5" },
                    { 536L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1069L, 268L, "6" },
                    { 537L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1073L, 269L, "5" },
                    { 538L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1074L, 269L, "6" },
                    { 539L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1078L, 270L, "5" },
                    { 540L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1078L, 270L, "6" },
                    { 541L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1081L, 271L, "5" },
                    { 542L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1081L, 271L, "6" },
                    { 543L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1085L, 272L, "5" },
                    { 544L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1085L, 272L, "6" },
                    { 545L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1089L, 273L, "5" },
                    { 546L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1089L, 273L, "6" },
                    { 547L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1093L, 274L, "5" },
                    { 548L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1094L, 274L, "6" },
                    { 549L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1098L, 275L, "5" },
                    { 550L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1098L, 275L, "6" },
                    { 551L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1101L, 276L, "5" },
                    { 552L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1101L, 276L, "6" },
                    { 553L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1105L, 277L, "5" },
                    { 554L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1105L, 277L, "6" },
                    { 555L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1109L, 278L, "5" },
                    { 556L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1109L, 278L, "6" },
                    { 557L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1113L, 279L, "5" },
                    { 558L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1114L, 279L, "6" },
                    { 559L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1118L, 280L, "5" },
                    { 560L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1118L, 280L, "6" },
                    { 561L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1121L, 281L, "5" },
                    { 562L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1121L, 281L, "6" },
                    { 563L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1125L, 282L, "5" },
                    { 564L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1125L, 282L, "6" },
                    { 565L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1129L, 283L, "5" },
                    { 566L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1129L, 283L, "6" },
                    { 567L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1133L, 284L, "5" },
                    { 568L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1134L, 284L, "6" },
                    { 569L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1138L, 285L, "5" },
                    { 570L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1138L, 285L, "6" },
                    { 571L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1141L, 286L, "5" },
                    { 572L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1141L, 286L, "6" },
                    { 573L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1145L, 287L, "5" },
                    { 574L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1145L, 287L, "6" },
                    { 575L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1149L, 288L, "5" },
                    { 576L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1149L, 288L, "6" },
                    { 577L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1153L, 289L, "5" },
                    { 578L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1154L, 289L, "6" },
                    { 579L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1158L, 290L, "5" },
                    { 580L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1158L, 290L, "6" },
                    { 581L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1161L, 291L, "5" },
                    { 582L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1161L, 291L, "6" },
                    { 583L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1165L, 292L, "5" },
                    { 584L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1165L, 292L, "6" },
                    { 585L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1169L, 293L, "5" },
                    { 586L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1169L, 293L, "6" },
                    { 587L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1173L, 294L, "5" },
                    { 588L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1174L, 294L, "6" },
                    { 589L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1178L, 295L, "5" },
                    { 590L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1178L, 295L, "6" },
                    { 591L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1181L, 296L, "5" },
                    { 592L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1181L, 296L, "6" },
                    { 593L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1185L, 297L, "5" },
                    { 594L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1185L, 297L, "6" },
                    { 595L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1189L, 298L, "5" },
                    { 596L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1189L, 298L, "6" },
                    { 597L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1193L, 299L, "5" },
                    { 598L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1194L, 299L, "6" },
                    { 599L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1198L, 300L, "5" },
                    { 600L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1198L, 300L, "6" },
                    { 601L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1201L, 301L, "5" },
                    { 602L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1201L, 301L, "6" },
                    { 603L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1205L, 302L, "5" },
                    { 604L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1205L, 302L, "6" },
                    { 605L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1209L, 303L, "5" },
                    { 606L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1209L, 303L, "6" },
                    { 607L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1213L, 304L, "5" },
                    { 608L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1214L, 304L, "6" },
                    { 609L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1218L, 305L, "5" },
                    { 610L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1218L, 305L, "6" },
                    { 611L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1221L, 306L, "5" },
                    { 612L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1221L, 306L, "6" },
                    { 613L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1225L, 307L, "5" },
                    { 614L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1225L, 307L, "6" },
                    { 615L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1229L, 308L, "5" },
                    { 616L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1229L, 308L, "6" },
                    { 617L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1233L, 309L, "5" },
                    { 618L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1234L, 309L, "6" },
                    { 619L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1238L, 310L, "5" },
                    { 620L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1238L, 310L, "6" },
                    { 621L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1241L, 311L, "5" },
                    { 622L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1241L, 311L, "6" },
                    { 623L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1245L, 312L, "5" },
                    { 624L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1245L, 312L, "6" },
                    { 625L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1249L, 313L, "5" },
                    { 626L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1249L, 313L, "6" },
                    { 627L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1253L, 314L, "5" },
                    { 628L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1254L, 314L, "6" },
                    { 629L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1258L, 315L, "5" },
                    { 630L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1258L, 315L, "6" },
                    { 631L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1261L, 316L, "5" },
                    { 632L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1261L, 316L, "6" },
                    { 633L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1265L, 317L, "5" },
                    { 634L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1265L, 317L, "6" },
                    { 635L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1269L, 318L, "5" },
                    { 636L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1269L, 318L, "6" },
                    { 637L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1273L, 319L, "5" },
                    { 638L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1274L, 319L, "6" },
                    { 639L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1278L, 320L, "5" },
                    { 640L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1278L, 320L, "6" },
                    { 641L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1281L, 321L, "5" },
                    { 642L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1281L, 321L, "6" },
                    { 643L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1285L, 322L, "5" },
                    { 644L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1285L, 322L, "6" },
                    { 645L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1289L, 323L, "5" },
                    { 646L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1289L, 323L, "6" },
                    { 647L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1293L, 324L, "5" },
                    { 648L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1294L, 324L, "6" },
                    { 649L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1298L, 325L, "5" },
                    { 650L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1298L, 325L, "6" },
                    { 651L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1301L, 326L, "5" },
                    { 652L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1301L, 326L, "6" },
                    { 653L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1305L, 327L, "5" },
                    { 654L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1305L, 327L, "6" },
                    { 655L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1309L, 328L, "5" },
                    { 656L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1309L, 328L, "6" },
                    { 657L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1313L, 329L, "5" },
                    { 658L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1314L, 329L, "6" },
                    { 659L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1318L, 330L, "5" },
                    { 660L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1318L, 330L, "6" },
                    { 661L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1321L, 331L, "5" },
                    { 662L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1321L, 331L, "6" },
                    { 663L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1325L, 332L, "5" },
                    { 664L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1325L, 332L, "6" },
                    { 665L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1329L, 333L, "5" },
                    { 666L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1329L, 333L, "6" },
                    { 667L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1333L, 334L, "5" },
                    { 668L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1334L, 334L, "6" },
                    { 669L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1338L, 335L, "5" },
                    { 670L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1338L, 335L, "6" },
                    { 671L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1341L, 336L, "5" },
                    { 672L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1341L, 336L, "6" },
                    { 673L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1345L, 337L, "5" },
                    { 674L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1345L, 337L, "6" },
                    { 675L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1349L, 338L, "5" },
                    { 676L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1349L, 338L, "6" },
                    { 677L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1353L, 339L, "5" },
                    { 678L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1354L, 339L, "6" },
                    { 679L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1358L, 340L, "5" },
                    { 680L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1358L, 340L, "6" },
                    { 681L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1361L, 341L, "5" },
                    { 682L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1361L, 341L, "6" },
                    { 683L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1365L, 342L, "5" },
                    { 684L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1365L, 342L, "6" },
                    { 685L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1369L, 343L, "5" },
                    { 686L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1369L, 343L, "6" },
                    { 687L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1373L, 344L, "5" },
                    { 688L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1374L, 344L, "6" },
                    { 689L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1378L, 345L, "5" },
                    { 690L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1378L, 345L, "6" },
                    { 691L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1381L, 346L, "5" },
                    { 692L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1381L, 346L, "6" },
                    { 693L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1385L, 347L, "5" },
                    { 694L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1385L, 347L, "6" },
                    { 695L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1389L, 348L, "5" },
                    { 696L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1389L, 348L, "6" },
                    { 697L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1393L, 349L, "5" },
                    { 698L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1394L, 349L, "6" },
                    { 699L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1398L, 350L, "5" },
                    { 700L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1398L, 350L, "6" },
                    { 701L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1401L, 351L, "5" },
                    { 702L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1401L, 351L, "6" },
                    { 703L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1405L, 352L, "5" },
                    { 704L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1405L, 352L, "6" },
                    { 705L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1409L, 353L, "5" },
                    { 706L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1409L, 353L, "6" },
                    { 707L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1413L, 354L, "5" },
                    { 708L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1414L, 354L, "6" },
                    { 709L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1418L, 355L, "5" },
                    { 710L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1418L, 355L, "6" },
                    { 711L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1421L, 356L, "5" },
                    { 712L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1421L, 356L, "6" },
                    { 713L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1425L, 357L, "5" },
                    { 714L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1425L, 357L, "6" },
                    { 715L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1429L, 358L, "5" },
                    { 716L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1429L, 358L, "6" },
                    { 717L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1433L, 359L, "5" },
                    { 718L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1434L, 359L, "6" },
                    { 719L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1438L, 360L, "5" },
                    { 720L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1438L, 360L, "6" },
                    { 721L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1441L, 361L, "5" },
                    { 722L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1441L, 361L, "6" },
                    { 723L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1445L, 362L, "5" },
                    { 724L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1445L, 362L, "6" },
                    { 725L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1449L, 363L, "5" },
                    { 726L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1449L, 363L, "6" },
                    { 727L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1453L, 364L, "5" },
                    { 728L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1454L, 364L, "6" },
                    { 729L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1458L, 365L, "5" },
                    { 730L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1458L, 365L, "6" },
                    { 731L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1461L, 366L, "5" },
                    { 732L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1461L, 366L, "6" },
                    { 733L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1465L, 367L, "5" },
                    { 734L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1465L, 367L, "6" },
                    { 735L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1469L, 368L, "5" },
                    { 736L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1469L, 368L, "6" },
                    { 737L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1473L, 369L, "5" },
                    { 738L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1474L, 369L, "6" },
                    { 739L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1478L, 370L, "5" },
                    { 740L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1478L, 370L, "6" },
                    { 741L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1481L, 371L, "5" },
                    { 742L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1481L, 371L, "6" },
                    { 743L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1485L, 372L, "5" },
                    { 744L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1485L, 372L, "6" },
                    { 745L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1489L, 373L, "5" },
                    { 746L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1489L, 373L, "6" },
                    { 747L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1493L, 374L, "5" },
                    { 748L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1494L, 374L, "6" },
                    { 749L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1498L, 375L, "5" },
                    { 750L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1498L, 375L, "6" },
                    { 751L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1501L, 376L, "5" },
                    { 752L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1501L, 376L, "6" },
                    { 753L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1505L, 377L, "5" },
                    { 754L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1505L, 377L, "6" },
                    { 755L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1509L, 378L, "5" },
                    { 756L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1509L, 378L, "6" },
                    { 757L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1513L, 379L, "5" },
                    { 758L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1514L, 379L, "6" },
                    { 759L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1518L, 380L, "5" },
                    { 760L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1518L, 380L, "6" },
                    { 761L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1521L, 381L, "5" },
                    { 762L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1521L, 381L, "6" },
                    { 763L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1525L, 382L, "5" },
                    { 764L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1525L, 382L, "6" },
                    { 765L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1529L, 383L, "5" },
                    { 766L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1529L, 383L, "6" },
                    { 767L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1533L, 384L, "5" },
                    { 768L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1534L, 384L, "6" },
                    { 769L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1538L, 385L, "5" },
                    { 770L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1538L, 385L, "6" },
                    { 771L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1541L, 386L, "5" },
                    { 772L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1541L, 386L, "6" },
                    { 773L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1545L, 387L, "5" },
                    { 774L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1545L, 387L, "6" },
                    { 775L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1549L, 388L, "5" },
                    { 776L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1549L, 388L, "6" },
                    { 777L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1553L, 389L, "5" },
                    { 778L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1554L, 389L, "6" },
                    { 779L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1558L, 390L, "5" },
                    { 780L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1558L, 390L, "6" },
                    { 781L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1561L, 391L, "5" },
                    { 782L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1561L, 391L, "6" },
                    { 783L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1565L, 392L, "5" },
                    { 784L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1565L, 392L, "6" },
                    { 785L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1569L, 393L, "5" },
                    { 786L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1569L, 393L, "6" },
                    { 787L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1573L, 394L, "5" },
                    { 788L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1574L, 394L, "6" },
                    { 789L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1578L, 395L, "5" },
                    { 790L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1578L, 395L, "6" },
                    { 791L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1581L, 396L, "5" },
                    { 792L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1581L, 396L, "6" },
                    { 793L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1585L, 397L, "5" },
                    { 794L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1585L, 397L, "6" },
                    { 795L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1589L, 398L, "5" },
                    { 796L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1589L, 398L, "6" },
                    { 797L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1593L, 399L, "5" },
                    { 798L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1594L, 399L, "6" },
                    { 799L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1598L, 400L, "5" },
                    { 800L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1598L, 400L, "6" },
                    { 801L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1601L, 401L, "5" },
                    { 802L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1601L, 401L, "6" },
                    { 803L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1605L, 402L, "5" },
                    { 804L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1605L, 402L, "6" },
                    { 805L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1609L, 403L, "5" },
                    { 806L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1609L, 403L, "6" },
                    { 807L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1613L, 404L, "5" },
                    { 808L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1614L, 404L, "6" },
                    { 809L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1618L, 405L, "5" },
                    { 810L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1618L, 405L, "6" },
                    { 811L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1621L, 406L, "5" },
                    { 812L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1621L, 406L, "6" },
                    { 813L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1625L, 407L, "5" },
                    { 814L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1625L, 407L, "6" },
                    { 815L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1629L, 408L, "5" },
                    { 816L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1629L, 408L, "6" },
                    { 817L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1633L, 409L, "5" },
                    { 818L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1634L, 409L, "6" },
                    { 819L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1638L, 410L, "5" },
                    { 820L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1638L, 410L, "6" },
                    { 821L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1641L, 411L, "5" },
                    { 822L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1641L, 411L, "6" },
                    { 823L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1645L, 412L, "5" },
                    { 824L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1645L, 412L, "6" },
                    { 825L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1649L, 413L, "5" },
                    { 826L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1649L, 413L, "6" },
                    { 827L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1653L, 414L, "5" },
                    { 828L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1654L, 414L, "6" },
                    { 829L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1658L, 415L, "5" },
                    { 830L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1658L, 415L, "6" },
                    { 831L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1661L, 416L, "5" },
                    { 832L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1661L, 416L, "6" },
                    { 833L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1665L, 417L, "5" },
                    { 834L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1665L, 417L, "6" },
                    { 835L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1669L, 418L, "5" },
                    { 836L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1669L, 418L, "6" },
                    { 837L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1673L, 419L, "5" },
                    { 838L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1674L, 419L, "6" },
                    { 839L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1678L, 420L, "5" },
                    { 840L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1678L, 420L, "6" },
                    { 841L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1681L, 421L, "5" },
                    { 842L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1681L, 421L, "6" },
                    { 843L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1685L, 422L, "5" },
                    { 844L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1685L, 422L, "6" },
                    { 845L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1689L, 423L, "5" },
                    { 846L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1689L, 423L, "6" },
                    { 847L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1693L, 424L, "5" },
                    { 848L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1694L, 424L, "6" },
                    { 849L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1698L, 425L, "5" },
                    { 850L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1698L, 425L, "6" },
                    { 851L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1701L, 426L, "5" },
                    { 852L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1701L, 426L, "6" },
                    { 853L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1705L, 427L, "5" },
                    { 854L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1705L, 427L, "6" },
                    { 855L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1709L, 428L, "5" },
                    { 856L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1709L, 428L, "6" },
                    { 857L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1713L, 429L, "5" },
                    { 858L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1714L, 429L, "6" },
                    { 859L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1718L, 430L, "5" },
                    { 860L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1718L, 430L, "6" },
                    { 861L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1721L, 431L, "5" },
                    { 862L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1721L, 431L, "6" },
                    { 863L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1725L, 432L, "5" },
                    { 864L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1725L, 432L, "6" },
                    { 865L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1729L, 433L, "5" },
                    { 866L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1729L, 433L, "6" },
                    { 867L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1733L, 434L, "5" },
                    { 868L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1734L, 434L, "6" },
                    { 869L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1738L, 435L, "5" },
                    { 870L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1738L, 435L, "6" },
                    { 871L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1741L, 436L, "5" },
                    { 872L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1741L, 436L, "6" },
                    { 873L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1745L, 437L, "5" },
                    { 874L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1745L, 437L, "6" },
                    { 875L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1749L, 438L, "5" },
                    { 876L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1749L, 438L, "6" },
                    { 877L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1753L, 439L, "5" },
                    { 878L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1754L, 439L, "6" },
                    { 879L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1758L, 440L, "5" },
                    { 880L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1758L, 440L, "6" },
                    { 881L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1761L, 441L, "5" },
                    { 882L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1761L, 441L, "6" },
                    { 883L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1765L, 442L, "5" },
                    { 884L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1765L, 442L, "6" },
                    { 885L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1769L, 443L, "5" },
                    { 886L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1769L, 443L, "6" },
                    { 887L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1773L, 444L, "5" },
                    { 888L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1774L, 444L, "6" },
                    { 889L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1778L, 445L, "5" },
                    { 890L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1778L, 445L, "6" },
                    { 891L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1781L, 446L, "5" },
                    { 892L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1781L, 446L, "6" },
                    { 893L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1785L, 447L, "5" },
                    { 894L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1785L, 447L, "6" },
                    { 895L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1789L, 448L, "5" },
                    { 896L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1789L, 448L, "6" },
                    { 897L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1793L, 449L, "5" },
                    { 898L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1794L, 449L, "6" },
                    { 899L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1798L, 450L, "5" },
                    { 900L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1798L, 450L, "6" },
                    { 901L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1801L, 451L, "5" },
                    { 902L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1801L, 451L, "6" },
                    { 903L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1805L, 452L, "5" },
                    { 904L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1805L, 452L, "6" },
                    { 905L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1809L, 453L, "5" },
                    { 906L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1809L, 453L, "6" },
                    { 907L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1813L, 454L, "5" },
                    { 908L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1814L, 454L, "6" },
                    { 909L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1818L, 455L, "5" },
                    { 910L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1818L, 455L, "6" },
                    { 911L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1821L, 456L, "5" },
                    { 912L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1821L, 456L, "6" },
                    { 913L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1825L, 457L, "5" },
                    { 914L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1825L, 457L, "6" },
                    { 915L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1829L, 458L, "5" },
                    { 916L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1829L, 458L, "6" },
                    { 917L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1833L, 459L, "5" },
                    { 918L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1834L, 459L, "6" },
                    { 919L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1838L, 460L, "5" },
                    { 920L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1838L, 460L, "6" },
                    { 921L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1841L, 461L, "5" },
                    { 922L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1841L, 461L, "6" },
                    { 923L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1845L, 462L, "5" },
                    { 924L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1845L, 462L, "6" },
                    { 925L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1849L, 463L, "5" },
                    { 926L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1849L, 463L, "6" },
                    { 927L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1853L, 464L, "5" },
                    { 928L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1854L, 464L, "6" },
                    { 929L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1858L, 465L, "5" },
                    { 930L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1858L, 465L, "6" },
                    { 931L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1861L, 466L, "5" },
                    { 932L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1861L, 466L, "6" },
                    { 933L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1865L, 467L, "5" },
                    { 934L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1865L, 467L, "6" },
                    { 935L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1869L, 468L, "5" },
                    { 936L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1869L, 468L, "6" },
                    { 937L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1873L, 469L, "5" },
                    { 938L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1874L, 469L, "6" },
                    { 939L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1878L, 470L, "5" },
                    { 940L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1878L, 470L, "6" },
                    { 941L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1881L, 471L, "5" },
                    { 942L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1881L, 471L, "6" },
                    { 943L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1885L, 472L, "5" },
                    { 944L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1885L, 472L, "6" },
                    { 945L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1889L, 473L, "5" },
                    { 946L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1889L, 473L, "6" },
                    { 947L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1893L, 474L, "5" },
                    { 948L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1894L, 474L, "6" },
                    { 949L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1898L, 475L, "5" },
                    { 950L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1898L, 475L, "6" },
                    { 951L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1901L, 476L, "5" },
                    { 952L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1901L, 476L, "6" },
                    { 953L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1905L, 477L, "5" },
                    { 954L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1905L, 477L, "6" },
                    { 955L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1909L, 478L, "5" },
                    { 956L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1909L, 478L, "6" },
                    { 957L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1913L, 479L, "5" },
                    { 958L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1914L, 479L, "6" },
                    { 959L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1918L, 480L, "5" },
                    { 960L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1918L, 480L, "6" },
                    { 961L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1921L, 481L, "5" },
                    { 962L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1921L, 481L, "6" },
                    { 963L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1925L, 482L, "5" },
                    { 964L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1925L, 482L, "6" },
                    { 965L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1929L, 483L, "5" },
                    { 966L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1929L, 483L, "6" },
                    { 967L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1933L, 484L, "5" },
                    { 968L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1934L, 484L, "6" },
                    { 969L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1938L, 485L, "5" },
                    { 970L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1938L, 485L, "6" },
                    { 971L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1941L, 486L, "5" },
                    { 972L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1941L, 486L, "6" },
                    { 973L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1945L, 487L, "5" },
                    { 974L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1945L, 487L, "6" },
                    { 975L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1949L, 488L, "5" },
                    { 976L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1949L, 488L, "6" },
                    { 977L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1953L, 489L, "5" },
                    { 978L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1954L, 489L, "6" },
                    { 979L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1958L, 490L, "5" },
                    { 980L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1958L, 490L, "6" },
                    { 981L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1961L, 491L, "5" },
                    { 982L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1961L, 491L, "6" },
                    { 983L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1965L, 492L, "5" },
                    { 984L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1965L, 492L, "6" },
                    { 985L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1969L, 493L, "5" },
                    { 986L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1969L, 493L, "6" },
                    { 987L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1973L, 494L, "5" },
                    { 988L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1974L, 494L, "6" },
                    { 989L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1978L, 495L, "5" },
                    { 990L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1978L, 495L, "6" },
                    { 991L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1981L, 496L, "5" },
                    { 992L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1981L, 496L, "6" },
                    { 993L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1985L, 497L, "5" },
                    { 994L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1985L, 497L, "6" },
                    { 995L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1989L, 498L, "5" },
                    { 996L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 1989L, 498L, "6" },
                    { 997L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 1993L, 499L, "5" },
                    { 998L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1994L, 499L, "6" },
                    { 999L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1998L, 500L, "5" },
                    { 1000L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 1998L, 500L, "6" },
                    { 1001L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2001L, 501L, "5" },
                    { 1002L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2001L, 501L, "6" },
                    { 1003L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2005L, 502L, "5" },
                    { 1004L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2005L, 502L, "6" },
                    { 1005L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2009L, 503L, "5" },
                    { 1006L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2009L, 503L, "6" },
                    { 1007L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2013L, 504L, "5" },
                    { 1008L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2014L, 504L, "6" },
                    { 1009L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2018L, 505L, "5" },
                    { 1010L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2018L, 505L, "6" },
                    { 1011L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2021L, 506L, "5" },
                    { 1012L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2021L, 506L, "6" },
                    { 1013L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2025L, 507L, "5" },
                    { 1014L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2025L, 507L, "6" },
                    { 1015L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2029L, 508L, "5" },
                    { 1016L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2029L, 508L, "6" },
                    { 1017L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2033L, 509L, "5" },
                    { 1018L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2034L, 509L, "6" },
                    { 1019L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2038L, 510L, "5" },
                    { 1020L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2038L, 510L, "6" },
                    { 1021L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2041L, 511L, "5" },
                    { 1022L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2041L, 511L, "6" },
                    { 1023L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2045L, 512L, "5" },
                    { 1024L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2045L, 512L, "6" },
                    { 1025L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2049L, 513L, "5" },
                    { 1026L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2049L, 513L, "6" },
                    { 1027L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2053L, 514L, "5" },
                    { 1028L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2054L, 514L, "6" },
                    { 1029L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2058L, 515L, "5" },
                    { 1030L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2058L, 515L, "6" },
                    { 1031L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2061L, 516L, "5" },
                    { 1032L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2061L, 516L, "6" },
                    { 1033L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2065L, 517L, "5" },
                    { 1034L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2065L, 517L, "6" },
                    { 1035L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2069L, 518L, "5" },
                    { 1036L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2069L, 518L, "6" },
                    { 1037L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2073L, 519L, "5" },
                    { 1038L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2074L, 519L, "6" },
                    { 1039L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2078L, 520L, "5" },
                    { 1040L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2078L, 520L, "6" },
                    { 1041L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2081L, 521L, "5" },
                    { 1042L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2081L, 521L, "6" },
                    { 1043L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2085L, 522L, "5" },
                    { 1044L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2085L, 522L, "6" },
                    { 1045L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2089L, 523L, "5" },
                    { 1046L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2089L, 523L, "6" },
                    { 1047L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2093L, 524L, "5" },
                    { 1048L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2094L, 524L, "6" },
                    { 1049L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2098L, 525L, "5" },
                    { 1050L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2098L, 525L, "6" },
                    { 1051L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2101L, 526L, "5" },
                    { 1052L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2101L, 526L, "6" },
                    { 1053L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2105L, 527L, "5" },
                    { 1054L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2105L, 527L, "6" },
                    { 1055L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2109L, 528L, "5" },
                    { 1056L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2109L, 528L, "6" },
                    { 1057L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2113L, 529L, "5" },
                    { 1058L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2114L, 529L, "6" },
                    { 1059L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2118L, 530L, "5" },
                    { 1060L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2118L, 530L, "6" },
                    { 1061L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2121L, 531L, "5" },
                    { 1062L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2121L, 531L, "6" },
                    { 1063L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2125L, 532L, "5" },
                    { 1064L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2125L, 532L, "6" },
                    { 1065L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2129L, 533L, "5" },
                    { 1066L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2129L, 533L, "6" },
                    { 1067L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2133L, 534L, "5" },
                    { 1068L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2134L, 534L, "6" },
                    { 1069L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2138L, 535L, "5" },
                    { 1070L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2138L, 535L, "6" },
                    { 1071L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2141L, 536L, "5" },
                    { 1072L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2141L, 536L, "6" },
                    { 1073L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2145L, 537L, "5" },
                    { 1074L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2145L, 537L, "6" },
                    { 1075L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2149L, 538L, "5" },
                    { 1076L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2149L, 538L, "6" },
                    { 1077L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2153L, 539L, "5" },
                    { 1078L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2154L, 539L, "6" },
                    { 1079L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2158L, 540L, "5" },
                    { 1080L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2158L, 540L, "6" },
                    { 1081L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2161L, 541L, "5" },
                    { 1082L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2161L, 541L, "6" },
                    { 1083L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2165L, 542L, "5" },
                    { 1084L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2165L, 542L, "6" },
                    { 1085L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2169L, 543L, "5" },
                    { 1086L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2169L, 543L, "6" },
                    { 1087L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2173L, 544L, "5" },
                    { 1088L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2174L, 544L, "6" },
                    { 1089L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2178L, 545L, "5" },
                    { 1090L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2178L, 545L, "6" },
                    { 1091L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2181L, 546L, "5" },
                    { 1092L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2181L, 546L, "6" },
                    { 1093L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2185L, 547L, "5" },
                    { 1094L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2185L, 547L, "6" },
                    { 1095L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2189L, 548L, "5" },
                    { 1096L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2189L, 548L, "6" },
                    { 1097L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2193L, 549L, "5" },
                    { 1098L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2194L, 549L, "6" },
                    { 1099L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2198L, 550L, "5" },
                    { 1100L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2198L, 550L, "6" },
                    { 1101L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2201L, 551L, "5" },
                    { 1102L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2201L, 551L, "6" },
                    { 1103L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2205L, 552L, "5" },
                    { 1104L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2205L, 552L, "6" },
                    { 1105L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2209L, 553L, "5" },
                    { 1106L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2209L, 553L, "6" },
                    { 1107L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2213L, 554L, "5" },
                    { 1108L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2214L, 554L, "6" },
                    { 1109L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2218L, 555L, "5" },
                    { 1110L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2218L, 555L, "6" },
                    { 1111L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2221L, 556L, "5" },
                    { 1112L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2221L, 556L, "6" },
                    { 1113L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2225L, 557L, "5" },
                    { 1114L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2225L, 557L, "6" },
                    { 1115L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2229L, 558L, "5" },
                    { 1116L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2229L, 558L, "6" },
                    { 1117L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2233L, 559L, "5" },
                    { 1118L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2234L, 559L, "6" },
                    { 1119L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2238L, 560L, "5" },
                    { 1120L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2238L, 560L, "6" },
                    { 1121L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2241L, 561L, "5" },
                    { 1122L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2241L, 561L, "6" },
                    { 1123L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2245L, 562L, "5" },
                    { 1124L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2245L, 562L, "6" },
                    { 1125L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2249L, 563L, "5" },
                    { 1126L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2249L, 563L, "6" },
                    { 1127L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2253L, 564L, "5" },
                    { 1128L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2254L, 564L, "6" },
                    { 1129L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2258L, 565L, "5" },
                    { 1130L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2258L, 565L, "6" },
                    { 1131L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2261L, 566L, "5" },
                    { 1132L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2261L, 566L, "6" },
                    { 1133L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2265L, 567L, "5" },
                    { 1134L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2265L, 567L, "6" },
                    { 1135L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2269L, 568L, "5" },
                    { 1136L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2269L, 568L, "6" },
                    { 1137L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2273L, 569L, "5" },
                    { 1138L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2274L, 569L, "6" },
                    { 1139L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2278L, 570L, "5" },
                    { 1140L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2278L, 570L, "6" },
                    { 1141L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2281L, 571L, "5" },
                    { 1142L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2281L, 571L, "6" },
                    { 1143L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2285L, 572L, "5" },
                    { 1144L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2285L, 572L, "6" },
                    { 1145L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2289L, 573L, "5" },
                    { 1146L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2289L, 573L, "6" },
                    { 1147L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2293L, 574L, "5" },
                    { 1148L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2294L, 574L, "6" },
                    { 1149L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2298L, 575L, "5" },
                    { 1150L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2298L, 575L, "6" },
                    { 1151L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2301L, 576L, "5" },
                    { 1152L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2301L, 576L, "6" },
                    { 1153L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2305L, 577L, "5" },
                    { 1154L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2305L, 577L, "6" },
                    { 1155L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2309L, 578L, "5" },
                    { 1156L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2309L, 578L, "6" },
                    { 1157L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2313L, 579L, "5" },
                    { 1158L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2314L, 579L, "6" },
                    { 1159L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2318L, 580L, "5" },
                    { 1160L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2318L, 580L, "6" },
                    { 1161L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2321L, 581L, "5" },
                    { 1162L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2321L, 581L, "6" },
                    { 1163L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2325L, 582L, "5" },
                    { 1164L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2325L, 582L, "6" },
                    { 1165L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2329L, 583L, "5" },
                    { 1166L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2329L, 583L, "6" },
                    { 1167L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2333L, 584L, "5" },
                    { 1168L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2334L, 584L, "6" },
                    { 1169L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2338L, 585L, "5" },
                    { 1170L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2338L, 585L, "6" },
                    { 1171L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2341L, 586L, "5" },
                    { 1172L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2341L, 586L, "6" },
                    { 1173L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2345L, 587L, "5" },
                    { 1174L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2345L, 587L, "6" },
                    { 1175L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2349L, 588L, "5" },
                    { 1176L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2349L, 588L, "6" },
                    { 1177L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2353L, 589L, "5" },
                    { 1178L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2354L, 589L, "6" },
                    { 1179L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2358L, 590L, "5" },
                    { 1180L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2358L, 590L, "6" },
                    { 1181L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2361L, 591L, "5" },
                    { 1182L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2361L, 591L, "6" },
                    { 1183L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2365L, 592L, "5" },
                    { 1184L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2365L, 592L, "6" },
                    { 1185L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2369L, 593L, "5" },
                    { 1186L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2369L, 593L, "6" },
                    { 1187L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2373L, 594L, "5" },
                    { 1188L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2374L, 594L, "6" },
                    { 1189L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2378L, 595L, "5" },
                    { 1190L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2378L, 595L, "6" },
                    { 1191L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2381L, 596L, "5" },
                    { 1192L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2381L, 596L, "6" },
                    { 1193L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2385L, 597L, "5" },
                    { 1194L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2385L, 597L, "6" },
                    { 1195L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2389L, 598L, "5" },
                    { 1196L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2389L, 598L, "6" },
                    { 1197L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2393L, 599L, "5" },
                    { 1198L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2394L, 599L, "6" },
                    { 1199L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2398L, 600L, "5" },
                    { 1200L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2398L, 600L, "6" },
                    { 1201L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2401L, 601L, "5" },
                    { 1202L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2401L, 601L, "6" },
                    { 1203L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2405L, 602L, "5" },
                    { 1204L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2405L, 602L, "6" },
                    { 1205L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2409L, 603L, "5" },
                    { 1206L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2409L, 603L, "6" },
                    { 1207L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2413L, 604L, "5" },
                    { 1208L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2414L, 604L, "6" },
                    { 1209L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2418L, 605L, "5" },
                    { 1210L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2418L, 605L, "6" },
                    { 1211L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2421L, 606L, "5" },
                    { 1212L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2421L, 606L, "6" },
                    { 1213L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2425L, 607L, "5" },
                    { 1214L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2425L, 607L, "6" },
                    { 1215L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2429L, 608L, "5" },
                    { 1216L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2429L, 608L, "6" },
                    { 1217L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2433L, 609L, "5" },
                    { 1218L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2434L, 609L, "6" },
                    { 1219L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2438L, 610L, "5" },
                    { 1220L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2438L, 610L, "6" },
                    { 1221L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2441L, 611L, "5" },
                    { 1222L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2441L, 611L, "6" },
                    { 1223L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2445L, 612L, "5" },
                    { 1224L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2445L, 612L, "6" },
                    { 1225L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2449L, 613L, "5" },
                    { 1226L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2449L, 613L, "6" },
                    { 1227L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2453L, 614L, "5" },
                    { 1228L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2454L, 614L, "6" },
                    { 1229L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2458L, 615L, "5" },
                    { 1230L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2458L, 615L, "6" },
                    { 1231L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2461L, 616L, "5" },
                    { 1232L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2461L, 616L, "6" },
                    { 1233L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2465L, 617L, "5" },
                    { 1234L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2465L, 617L, "6" },
                    { 1235L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2469L, 618L, "5" },
                    { 1236L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2469L, 618L, "6" },
                    { 1237L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2473L, 619L, "5" },
                    { 1238L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2474L, 619L, "6" },
                    { 1239L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2478L, 620L, "5" },
                    { 1240L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2478L, 620L, "6" },
                    { 1241L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2481L, 621L, "5" },
                    { 1242L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2481L, 621L, "6" },
                    { 1243L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2485L, 622L, "5" },
                    { 1244L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2485L, 622L, "6" },
                    { 1245L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2489L, 623L, "5" },
                    { 1246L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2489L, 623L, "6" },
                    { 1247L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2493L, 624L, "5" },
                    { 1248L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2494L, 624L, "6" },
                    { 1249L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2498L, 625L, "5" },
                    { 1250L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2498L, 625L, "6" },
                    { 1251L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2501L, 626L, "5" },
                    { 1252L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2501L, 626L, "6" },
                    { 1253L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2505L, 627L, "5" },
                    { 1254L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2505L, 627L, "6" },
                    { 1255L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2509L, 628L, "5" },
                    { 1256L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2509L, 628L, "6" },
                    { 1257L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2513L, 629L, "5" },
                    { 1258L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2514L, 629L, "6" },
                    { 1259L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2518L, 630L, "5" },
                    { 1260L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2518L, 630L, "6" },
                    { 1261L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2521L, 631L, "5" },
                    { 1262L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2521L, 631L, "6" },
                    { 1263L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2525L, 632L, "5" },
                    { 1264L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2525L, 632L, "6" },
                    { 1265L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2529L, 633L, "5" },
                    { 1266L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2529L, 633L, "6" },
                    { 1267L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2533L, 634L, "5" },
                    { 1268L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2534L, 634L, "6" },
                    { 1269L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2538L, 635L, "5" },
                    { 1270L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2538L, 635L, "6" },
                    { 1271L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2541L, 636L, "5" },
                    { 1272L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2541L, 636L, "6" },
                    { 1273L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2545L, 637L, "5" },
                    { 1274L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2545L, 637L, "6" },
                    { 1275L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2549L, 638L, "5" },
                    { 1276L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2549L, 638L, "6" },
                    { 1277L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2553L, 639L, "5" },
                    { 1278L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2554L, 639L, "6" },
                    { 1279L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2558L, 640L, "5" },
                    { 1280L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2558L, 640L, "6" },
                    { 1281L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2561L, 641L, "5" },
                    { 1282L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2561L, 641L, "6" },
                    { 1283L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2565L, 642L, "5" },
                    { 1284L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2565L, 642L, "6" },
                    { 1285L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2569L, 643L, "5" },
                    { 1286L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2569L, 643L, "6" },
                    { 1287L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2573L, 644L, "5" },
                    { 1288L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2574L, 644L, "6" },
                    { 1289L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2578L, 645L, "5" },
                    { 1290L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2578L, 645L, "6" },
                    { 1291L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2581L, 646L, "5" },
                    { 1292L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2581L, 646L, "6" },
                    { 1293L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2585L, 647L, "5" },
                    { 1294L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2585L, 647L, "6" },
                    { 1295L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2589L, 648L, "5" },
                    { 1296L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2589L, 648L, "6" },
                    { 1297L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2593L, 649L, "5" },
                    { 1298L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2594L, 649L, "6" },
                    { 1299L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2598L, 650L, "5" },
                    { 1300L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2598L, 650L, "6" },
                    { 1301L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2601L, 651L, "5" },
                    { 1302L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2601L, 651L, "6" },
                    { 1303L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2605L, 652L, "5" },
                    { 1304L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2605L, 652L, "6" },
                    { 1305L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2609L, 653L, "5" },
                    { 1306L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2609L, 653L, "6" },
                    { 1307L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2613L, 654L, "5" },
                    { 1308L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2614L, 654L, "6" },
                    { 1309L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2618L, 655L, "5" },
                    { 1310L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2618L, 655L, "6" },
                    { 1311L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2621L, 656L, "5" },
                    { 1312L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2621L, 656L, "6" },
                    { 1313L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2625L, 657L, "5" },
                    { 1314L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2625L, 657L, "6" },
                    { 1315L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2629L, 658L, "5" },
                    { 1316L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2629L, 658L, "6" },
                    { 1317L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2633L, 659L, "5" },
                    { 1318L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2634L, 659L, "6" },
                    { 1319L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2638L, 660L, "5" },
                    { 1320L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2638L, 660L, "6" },
                    { 1321L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2641L, 661L, "5" },
                    { 1322L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2641L, 661L, "6" },
                    { 1323L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2645L, 662L, "5" },
                    { 1324L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2645L, 662L, "6" },
                    { 1325L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2649L, 663L, "5" },
                    { 1326L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2649L, 663L, "6" },
                    { 1327L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2653L, 664L, "5" },
                    { 1328L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2654L, 664L, "6" },
                    { 1329L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2658L, 665L, "5" },
                    { 1330L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2658L, 665L, "6" },
                    { 1331L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2661L, 666L, "5" },
                    { 1332L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2661L, 666L, "6" },
                    { 1333L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2665L, 667L, "5" },
                    { 1334L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2665L, 667L, "6" },
                    { 1335L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2669L, 668L, "5" },
                    { 1336L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2669L, 668L, "6" },
                    { 1337L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2673L, 669L, "5" },
                    { 1338L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2674L, 669L, "6" },
                    { 1339L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2678L, 670L, "5" },
                    { 1340L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2678L, 670L, "6" },
                    { 1341L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2681L, 671L, "5" },
                    { 1342L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2681L, 671L, "6" },
                    { 1343L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2685L, 672L, "5" },
                    { 1344L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2685L, 672L, "6" },
                    { 1345L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2689L, 673L, "5" },
                    { 1346L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2689L, 673L, "6" },
                    { 1347L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2693L, 674L, "5" },
                    { 1348L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2694L, 674L, "6" },
                    { 1349L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2698L, 675L, "5" },
                    { 1350L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2698L, 675L, "6" },
                    { 1351L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2701L, 676L, "5" },
                    { 1352L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2701L, 676L, "6" },
                    { 1353L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2705L, 677L, "5" },
                    { 1354L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2705L, 677L, "6" },
                    { 1355L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2709L, 678L, "5" },
                    { 1356L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2709L, 678L, "6" },
                    { 1357L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2713L, 679L, "5" },
                    { 1358L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2714L, 679L, "6" },
                    { 1359L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2718L, 680L, "5" },
                    { 1360L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2718L, 680L, "6" },
                    { 1361L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2721L, 681L, "5" },
                    { 1362L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2721L, 681L, "6" },
                    { 1363L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2725L, 682L, "5" },
                    { 1364L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2725L, 682L, "6" },
                    { 1365L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2729L, 683L, "5" },
                    { 1366L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2729L, 683L, "6" },
                    { 1367L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2733L, 684L, "5" },
                    { 1368L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2734L, 684L, "6" },
                    { 1369L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2738L, 685L, "5" },
                    { 1370L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2738L, 685L, "6" },
                    { 1371L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2741L, 686L, "5" },
                    { 1372L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2741L, 686L, "6" },
                    { 1373L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2745L, 687L, "5" },
                    { 1374L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2745L, 687L, "6" },
                    { 1375L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2749L, 688L, "5" },
                    { 1376L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2749L, 688L, "6" },
                    { 1377L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2753L, 689L, "5" },
                    { 1378L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2754L, 689L, "6" },
                    { 1379L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2758L, 690L, "5" },
                    { 1380L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2758L, 690L, "6" },
                    { 1381L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2761L, 691L, "5" },
                    { 1382L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2761L, 691L, "6" },
                    { 1383L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2765L, 692L, "5" },
                    { 1384L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2765L, 692L, "6" },
                    { 1385L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2769L, 693L, "5" },
                    { 1386L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2769L, 693L, "6" },
                    { 1387L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2773L, 694L, "5" },
                    { 1388L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2774L, 694L, "6" },
                    { 1389L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2778L, 695L, "5" },
                    { 1390L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2778L, 695L, "6" },
                    { 1391L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2781L, 696L, "5" },
                    { 1392L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2781L, 696L, "6" },
                    { 1393L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2785L, 697L, "5" },
                    { 1394L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2785L, 697L, "6" },
                    { 1395L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2789L, 698L, "5" },
                    { 1396L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2789L, 698L, "6" },
                    { 1397L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2793L, 699L, "5" },
                    { 1398L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2794L, 699L, "6" },
                    { 1399L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2798L, 700L, "5" },
                    { 1400L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2798L, 700L, "6" },
                    { 1401L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2801L, 701L, "5" },
                    { 1402L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2801L, 701L, "6" },
                    { 1403L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2805L, 702L, "5" },
                    { 1404L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2805L, 702L, "6" },
                    { 1405L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2809L, 703L, "5" },
                    { 1406L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2809L, 703L, "6" },
                    { 1407L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2813L, 704L, "5" },
                    { 1408L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2814L, 704L, "6" },
                    { 1409L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2818L, 705L, "5" },
                    { 1410L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2818L, 705L, "6" },
                    { 1411L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2821L, 706L, "5" },
                    { 1412L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2821L, 706L, "6" },
                    { 1413L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2825L, 707L, "5" },
                    { 1414L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2825L, 707L, "6" },
                    { 1415L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2829L, 708L, "5" },
                    { 1416L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2829L, 708L, "6" },
                    { 1417L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2833L, 709L, "5" },
                    { 1418L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2834L, 709L, "6" },
                    { 1419L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2838L, 710L, "5" },
                    { 1420L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2838L, 710L, "6" },
                    { 1421L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2841L, 711L, "5" },
                    { 1422L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2841L, 711L, "6" },
                    { 1423L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2845L, 712L, "5" },
                    { 1424L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2845L, 712L, "6" },
                    { 1425L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2849L, 713L, "5" },
                    { 1426L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2849L, 713L, "6" },
                    { 1427L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2853L, 714L, "5" },
                    { 1428L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2854L, 714L, "6" },
                    { 1429L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2858L, 715L, "5" },
                    { 1430L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2858L, 715L, "6" },
                    { 1431L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2861L, 716L, "5" },
                    { 1432L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2861L, 716L, "6" },
                    { 1433L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2865L, 717L, "5" },
                    { 1434L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2865L, 717L, "6" },
                    { 1435L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2869L, 718L, "5" },
                    { 1436L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2869L, 718L, "6" },
                    { 1437L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2873L, 719L, "5" },
                    { 1438L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2874L, 719L, "6" },
                    { 1439L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2878L, 720L, "5" },
                    { 1440L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2878L, 720L, "6" },
                    { 1441L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2881L, 721L, "5" },
                    { 1442L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2881L, 721L, "6" },
                    { 1443L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2885L, 722L, "5" },
                    { 1444L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2885L, 722L, "6" },
                    { 1445L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2889L, 723L, "5" },
                    { 1446L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2889L, 723L, "6" },
                    { 1447L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2893L, 724L, "5" },
                    { 1448L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2894L, 724L, "6" },
                    { 1449L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2898L, 725L, "5" },
                    { 1450L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2898L, 725L, "6" },
                    { 1451L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2901L, 726L, "5" },
                    { 1452L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2901L, 726L, "6" },
                    { 1453L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2905L, 727L, "5" },
                    { 1454L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2905L, 727L, "6" },
                    { 1455L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2909L, 728L, "5" },
                    { 1456L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2909L, 728L, "6" },
                    { 1457L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2913L, 729L, "5" },
                    { 1458L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2914L, 729L, "6" },
                    { 1459L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2918L, 730L, "5" },
                    { 1460L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2918L, 730L, "6" },
                    { 1461L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2921L, 731L, "5" },
                    { 1462L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2921L, 731L, "6" },
                    { 1463L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2925L, 732L, "5" },
                    { 1464L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2925L, 732L, "6" },
                    { 1465L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2929L, 733L, "5" },
                    { 1466L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2929L, 733L, "6" },
                    { 1467L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2933L, 734L, "5" },
                    { 1468L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2934L, 734L, "6" },
                    { 1469L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2938L, 735L, "5" },
                    { 1470L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2938L, 735L, "6" },
                    { 1471L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2941L, 736L, "5" },
                    { 1472L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2941L, 736L, "6" },
                    { 1473L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2945L, 737L, "5" },
                    { 1474L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2945L, 737L, "6" },
                    { 1475L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2949L, 738L, "5" },
                    { 1476L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2949L, 738L, "6" },
                    { 1477L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2953L, 739L, "5" },
                    { 1478L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2954L, 739L, "6" },
                    { 1479L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2958L, 740L, "5" },
                    { 1480L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2958L, 740L, "6" },
                    { 1481L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2961L, 741L, "5" },
                    { 1482L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2961L, 741L, "6" },
                    { 1483L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2965L, 742L, "5" },
                    { 1484L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2965L, 742L, "6" },
                    { 1485L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2969L, 743L, "5" },
                    { 1486L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2969L, 743L, "6" },
                    { 1487L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2973L, 744L, "5" },
                    { 1488L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2974L, 744L, "6" },
                    { 1489L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2978L, 745L, "5" },
                    { 1490L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2978L, 745L, "6" },
                    { 1491L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2981L, 746L, "5" },
                    { 1492L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2981L, 746L, "6" },
                    { 1493L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2985L, 747L, "5" },
                    { 1494L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2985L, 747L, "6" },
                    { 1495L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2989L, 748L, "5" },
                    { 1496L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), true, null, 2989L, 748L, "6" },
                    { 1497L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2993L, 749L, "5" },
                    { 1498L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2994L, 749L, "6" },
                    { 1499L, new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2998L, 750L, "5" },
                    { 1500L, new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), false, null, 2998L, 750L, "6" }
                });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 566, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 201L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 202L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 203L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 204L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 205L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 206L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 207L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 208L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 209L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 210L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 211L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 212L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 213L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 214L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 215L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 216L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 217L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 218L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 219L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 220L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 221L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 222L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 223L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 224L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 225L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 226L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 227L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 228L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 229L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 230L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 231L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 232L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 233L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 234L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 235L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 236L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 237L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 238L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 239L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 240L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 241L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 242L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 243L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 244L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 245L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 246L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 247L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 248L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 249L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 250L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 251L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 252L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 253L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 254L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 255L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 256L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 257L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 258L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 259L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 260L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 261L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 262L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 263L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 264L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 265L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 266L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 267L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 268L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 269L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 270L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 271L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 272L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 273L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 274L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 275L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 276L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 277L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 278L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 279L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 280L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 281L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 282L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 283L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 284L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 285L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 286L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 287L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 288L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 289L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 290L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 291L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 292L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 293L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 294L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 295L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 296L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 297L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 298L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 299L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 300L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 21, 10, 18, 567, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UserId",
                value: "5");

            migrationBuilder.UpdateData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AdminReviewerId", "ReviewedAt", "UserId" },
                values: new object[] { "1", new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "6" });

            migrationBuilder.UpdateData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AdminReviewerId", "UserId" },
                values: new object[] { "1", "7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1L,
                column: "Content",
                value: "Welcome to the online learning system!");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2L,
                column: "Content",
                value: "Thank you admin, I'm very excited!");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3L,
                column: "Content",
                value: "Do you want to join the study group?");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4L,
                column: "Content",
                value: "Ok, I'm very interested.");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5L,
                column: "Content",
                value: "We have received your mentor application.");

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                columns: new[] { "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7584), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                columns: new[] { "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7595), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7599), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7601), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7602), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7605), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7606), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7608), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7610), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7611), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7613), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7614), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7616), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7617), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7618), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7620), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7621), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7623), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7624), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7625), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7627), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7628), "6" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7629), "5" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 13, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7630), "6" });

            migrationBuilder.InsertData(
                table: "QuizResults",
                columns: new[] { "QuizResultId", "CorrectAnswers", "CreatedAt", "EndTime", "QuizId", "Score", "StartTime", "TotalQuestions", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 25L, 4, new DateTime(2025, 3, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), 13L, 80.00m, new DateTime(2025, 3, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7632), "5" },
                    { 26L, 3, new DateTime(2025, 3, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), 13L, 60.00m, new DateTime(2025, 3, 14, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7633), "6" },
                    { 27L, 4, new DateTime(2025, 3, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), 14L, 80.00m, new DateTime(2025, 3, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7634), "5" },
                    { 28L, 3, new DateTime(2025, 3, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), 14L, 60.00m, new DateTime(2025, 3, 15, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7635), "6" },
                    { 29L, 4, new DateTime(2025, 3, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), 15L, 80.00m, new DateTime(2025, 3, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7637), "5" },
                    { 30L, 3, new DateTime(2025, 3, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), 15L, 60.00m, new DateTime(2025, 3, 16, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7638), "6" },
                    { 31L, 4, new DateTime(2025, 3, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), 16L, 80.00m, new DateTime(2025, 3, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7639), "5" },
                    { 32L, 3, new DateTime(2025, 3, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), 16L, 60.00m, new DateTime(2025, 3, 17, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7641), "6" },
                    { 33L, 4, new DateTime(2025, 3, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), 17L, 80.00m, new DateTime(2025, 3, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7642), "5" },
                    { 34L, 3, new DateTime(2025, 3, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), 17L, 60.00m, new DateTime(2025, 3, 18, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7656), "6" },
                    { 35L, 4, new DateTime(2025, 3, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), 18L, 80.00m, new DateTime(2025, 3, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7657), "5" },
                    { 36L, 3, new DateTime(2025, 3, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), 18L, 60.00m, new DateTime(2025, 3, 19, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7659), "6" },
                    { 37L, 4, new DateTime(2025, 3, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), 19L, 80.00m, new DateTime(2025, 3, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7660), "5" },
                    { 38L, 3, new DateTime(2025, 3, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), 19L, 60.00m, new DateTime(2025, 3, 20, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7661), "6" },
                    { 39L, 4, new DateTime(2025, 3, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), 20L, 80.00m, new DateTime(2025, 3, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7662), "5" },
                    { 40L, 3, new DateTime(2025, 3, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), 20L, 60.00m, new DateTime(2025, 3, 21, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7664), "6" },
                    { 41L, 4, new DateTime(2025, 3, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), 21L, 80.00m, new DateTime(2025, 3, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7665), "5" },
                    { 42L, 3, new DateTime(2025, 3, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), 21L, 60.00m, new DateTime(2025, 3, 22, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7666), "6" },
                    { 43L, 4, new DateTime(2025, 3, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), 22L, 80.00m, new DateTime(2025, 3, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7668), "5" },
                    { 44L, 3, new DateTime(2025, 3, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), 22L, 60.00m, new DateTime(2025, 3, 23, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7669), "6" },
                    { 45L, 4, new DateTime(2025, 3, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), 23L, 80.00m, new DateTime(2025, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7670), "5" },
                    { 46L, 3, new DateTime(2025, 3, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), 23L, 60.00m, new DateTime(2025, 3, 24, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7672), "6" },
                    { 47L, 4, new DateTime(2025, 3, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), 24L, 80.00m, new DateTime(2025, 3, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7673), "5" },
                    { 48L, 3, new DateTime(2025, 3, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), 24L, 60.00m, new DateTime(2025, 3, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7674), "6" },
                    { 49L, 4, new DateTime(2025, 3, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), 25L, 80.00m, new DateTime(2025, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7675), "5" },
                    { 50L, 3, new DateTime(2025, 3, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), 25L, 60.00m, new DateTime(2025, 3, 26, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7677), "6" },
                    { 51L, 4, new DateTime(2025, 3, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), 26L, 80.00m, new DateTime(2025, 3, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7678), "5" },
                    { 52L, 3, new DateTime(2025, 3, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), 26L, 60.00m, new DateTime(2025, 3, 27, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7679), "6" },
                    { 53L, 4, new DateTime(2025, 3, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), 27L, 80.00m, new DateTime(2025, 3, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7680), "5" },
                    { 54L, 3, new DateTime(2025, 3, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), 27L, 60.00m, new DateTime(2025, 3, 28, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7681), "6" },
                    { 55L, 4, new DateTime(2025, 3, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), 28L, 80.00m, new DateTime(2025, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7683), "5" },
                    { 56L, 3, new DateTime(2025, 3, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), 28L, 60.00m, new DateTime(2025, 3, 29, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7684), "6" },
                    { 57L, 4, new DateTime(2025, 3, 29, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 29, 10, 15, 0, 0, DateTimeKind.Unspecified), 29L, 80.00m, new DateTime(2025, 3, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7685), "5" },
                    { 58L, 3, new DateTime(2025, 3, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), 29L, 60.00m, new DateTime(2025, 3, 30, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7686), "6" },
                    { 59L, 4, new DateTime(2025, 3, 30, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 10, 15, 0, 0, DateTimeKind.Unspecified), 30L, 80.00m, new DateTime(2025, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7688), "5" },
                    { 60L, 3, new DateTime(2025, 3, 31, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 31, 9, 45, 0, 0, DateTimeKind.Unspecified), 30L, 60.00m, new DateTime(2025, 3, 31, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7689), "6" },
                    { 61L, 4, new DateTime(2025, 3, 31, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 31, 10, 15, 0, 0, DateTimeKind.Unspecified), 31L, 80.00m, new DateTime(2025, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7690), "5" },
                    { 62L, 3, new DateTime(2025, 4, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 31L, 60.00m, new DateTime(2025, 4, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7691), "6" },
                    { 63L, 4, new DateTime(2025, 4, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 32L, 80.00m, new DateTime(2025, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7693), "5" },
                    { 64L, 3, new DateTime(2025, 4, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 32L, 60.00m, new DateTime(2025, 4, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7694), "6" },
                    { 65L, 4, new DateTime(2025, 4, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 33L, 80.00m, new DateTime(2025, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7695), "5" },
                    { 66L, 3, new DateTime(2025, 4, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), 33L, 60.00m, new DateTime(2025, 4, 3, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7697), "6" },
                    { 67L, 4, new DateTime(2025, 4, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), 34L, 80.00m, new DateTime(2025, 4, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7698), "5" },
                    { 68L, 3, new DateTime(2025, 4, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), 34L, 60.00m, new DateTime(2025, 4, 4, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7699), "6" },
                    { 69L, 4, new DateTime(2025, 4, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), 35L, 80.00m, new DateTime(2025, 4, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7701), "5" },
                    { 70L, 3, new DateTime(2025, 4, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), 35L, 60.00m, new DateTime(2025, 4, 5, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7702), "6" },
                    { 71L, 4, new DateTime(2025, 4, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), 36L, 80.00m, new DateTime(2025, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7703), "5" },
                    { 72L, 3, new DateTime(2025, 4, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), 36L, 60.00m, new DateTime(2025, 4, 6, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7704), "6" },
                    { 73L, 4, new DateTime(2025, 4, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), 37L, 80.00m, new DateTime(2025, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7706), "5" },
                    { 74L, 3, new DateTime(2025, 4, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), 37L, 60.00m, new DateTime(2025, 4, 7, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7707), "6" },
                    { 75L, 4, new DateTime(2025, 4, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), 38L, 80.00m, new DateTime(2025, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7709), "5" },
                    { 76L, 3, new DateTime(2025, 4, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), 38L, 60.00m, new DateTime(2025, 4, 8, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7710), "6" },
                    { 77L, 4, new DateTime(2025, 4, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), 39L, 80.00m, new DateTime(2025, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7711), "5" },
                    { 78L, 3, new DateTime(2025, 4, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), 39L, 60.00m, new DateTime(2025, 4, 9, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7712), "6" },
                    { 79L, 4, new DateTime(2025, 4, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), 40L, 80.00m, new DateTime(2025, 4, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7713), "5" },
                    { 80L, 3, new DateTime(2025, 4, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), 40L, 60.00m, new DateTime(2025, 4, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7715), "6" },
                    { 81L, 4, new DateTime(2025, 4, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), 41L, 80.00m, new DateTime(2025, 4, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7716), "5" },
                    { 82L, 3, new DateTime(2025, 4, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), 41L, 60.00m, new DateTime(2025, 4, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7717), "6" },
                    { 83L, 4, new DateTime(2025, 4, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), 42L, 80.00m, new DateTime(2025, 4, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7719), "5" },
                    { 84L, 3, new DateTime(2025, 4, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), 42L, 60.00m, new DateTime(2025, 4, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7720), "6" },
                    { 85L, 4, new DateTime(2025, 4, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), 43L, 80.00m, new DateTime(2025, 4, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7721), "5" },
                    { 86L, 3, new DateTime(2025, 4, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), 43L, 60.00m, new DateTime(2025, 4, 13, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7722), "6" },
                    { 87L, 4, new DateTime(2025, 4, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), 44L, 80.00m, new DateTime(2025, 4, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7724), "5" },
                    { 88L, 3, new DateTime(2025, 4, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), 44L, 60.00m, new DateTime(2025, 4, 14, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7725), "6" },
                    { 89L, 4, new DateTime(2025, 4, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), 45L, 80.00m, new DateTime(2025, 4, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7726), "5" },
                    { 90L, 3, new DateTime(2025, 4, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), 45L, 60.00m, new DateTime(2025, 4, 15, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7727), "6" },
                    { 91L, 4, new DateTime(2025, 4, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), 46L, 80.00m, new DateTime(2025, 4, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7729), "5" },
                    { 92L, 3, new DateTime(2025, 4, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), 46L, 60.00m, new DateTime(2025, 4, 16, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7741), "6" },
                    { 93L, 4, new DateTime(2025, 4, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), 47L, 80.00m, new DateTime(2025, 4, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7742), "5" },
                    { 94L, 3, new DateTime(2025, 4, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), 47L, 60.00m, new DateTime(2025, 4, 17, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7744), "6" },
                    { 95L, 4, new DateTime(2025, 4, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), 48L, 80.00m, new DateTime(2025, 4, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7745), "5" },
                    { 96L, 3, new DateTime(2025, 4, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), 48L, 60.00m, new DateTime(2025, 4, 18, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7746), "6" },
                    { 97L, 4, new DateTime(2025, 4, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), 49L, 80.00m, new DateTime(2025, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7747), "5" },
                    { 98L, 3, new DateTime(2025, 4, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), 49L, 60.00m, new DateTime(2025, 4, 19, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7749), "6" },
                    { 99L, 4, new DateTime(2025, 4, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), 50L, 80.00m, new DateTime(2025, 4, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7750), "5" },
                    { 100L, 3, new DateTime(2025, 4, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), 50L, 60.00m, new DateTime(2025, 4, 20, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7751), "6" },
                    { 101L, 4, new DateTime(2025, 4, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), 51L, 80.00m, new DateTime(2025, 4, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7753), "5" },
                    { 102L, 3, new DateTime(2025, 4, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), 51L, 60.00m, new DateTime(2025, 4, 21, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7754), "6" },
                    { 103L, 4, new DateTime(2025, 4, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), 52L, 80.00m, new DateTime(2025, 4, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7755), "5" },
                    { 104L, 3, new DateTime(2025, 4, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), 52L, 60.00m, new DateTime(2025, 4, 22, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7756), "6" },
                    { 105L, 4, new DateTime(2025, 4, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), 53L, 80.00m, new DateTime(2025, 4, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7758), "5" },
                    { 106L, 3, new DateTime(2025, 4, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), 53L, 60.00m, new DateTime(2025, 4, 23, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7759), "6" },
                    { 107L, 4, new DateTime(2025, 4, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), 54L, 80.00m, new DateTime(2025, 4, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7760), "5" },
                    { 108L, 3, new DateTime(2025, 4, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), 54L, 60.00m, new DateTime(2025, 4, 24, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7762), "6" },
                    { 109L, 4, new DateTime(2025, 4, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), 55L, 80.00m, new DateTime(2025, 4, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7763), "5" },
                    { 110L, 3, new DateTime(2025, 4, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), 55L, 60.00m, new DateTime(2025, 4, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7764), "6" },
                    { 111L, 4, new DateTime(2025, 4, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), 56L, 80.00m, new DateTime(2025, 4, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7766), "5" },
                    { 112L, 3, new DateTime(2025, 4, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), 56L, 60.00m, new DateTime(2025, 4, 26, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7767), "6" },
                    { 113L, 4, new DateTime(2025, 4, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), 57L, 80.00m, new DateTime(2025, 4, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7768), "5" },
                    { 114L, 3, new DateTime(2025, 4, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), 57L, 60.00m, new DateTime(2025, 4, 27, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7769), "6" },
                    { 115L, 4, new DateTime(2025, 4, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), 58L, 80.00m, new DateTime(2025, 4, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7771), "5" },
                    { 116L, 3, new DateTime(2025, 4, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), 58L, 60.00m, new DateTime(2025, 4, 28, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7772), "6" },
                    { 117L, 4, new DateTime(2025, 4, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), 59L, 80.00m, new DateTime(2025, 4, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7773), "5" },
                    { 118L, 3, new DateTime(2025, 4, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), 59L, 60.00m, new DateTime(2025, 4, 29, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7774), "6" },
                    { 119L, 4, new DateTime(2025, 4, 29, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 10, 15, 0, 0, DateTimeKind.Unspecified), 60L, 80.00m, new DateTime(2025, 4, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7776), "5" },
                    { 120L, 3, new DateTime(2025, 4, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), 60L, 60.00m, new DateTime(2025, 4, 30, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7777), "6" },
                    { 121L, 4, new DateTime(2025, 4, 30, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 10, 15, 0, 0, DateTimeKind.Unspecified), 61L, 80.00m, new DateTime(2025, 4, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7778), "5" },
                    { 122L, 3, new DateTime(2025, 5, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 61L, 60.00m, new DateTime(2025, 5, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7779), "6" },
                    { 123L, 4, new DateTime(2025, 5, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 62L, 80.00m, new DateTime(2025, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7781), "5" },
                    { 124L, 3, new DateTime(2025, 5, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 62L, 60.00m, new DateTime(2025, 5, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7782), "6" },
                    { 125L, 4, new DateTime(2025, 5, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 63L, 80.00m, new DateTime(2025, 5, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7783), "5" },
                    { 126L, 3, new DateTime(2025, 5, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), 63L, 60.00m, new DateTime(2025, 5, 3, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7784), "6" },
                    { 127L, 4, new DateTime(2025, 5, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), 64L, 80.00m, new DateTime(2025, 5, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7786), "5" },
                    { 128L, 3, new DateTime(2025, 5, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), 64L, 60.00m, new DateTime(2025, 5, 4, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7787), "6" },
                    { 129L, 4, new DateTime(2025, 5, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), 65L, 80.00m, new DateTime(2025, 5, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7788), "5" },
                    { 130L, 3, new DateTime(2025, 5, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), 65L, 60.00m, new DateTime(2025, 5, 5, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7790), "6" },
                    { 131L, 4, new DateTime(2025, 5, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), 66L, 80.00m, new DateTime(2025, 5, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7792), "5" },
                    { 132L, 3, new DateTime(2025, 5, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), 66L, 60.00m, new DateTime(2025, 5, 6, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7793), "6" },
                    { 133L, 4, new DateTime(2025, 5, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), 67L, 80.00m, new DateTime(2025, 5, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7794), "5" },
                    { 134L, 3, new DateTime(2025, 5, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), 67L, 60.00m, new DateTime(2025, 5, 7, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7795), "6" },
                    { 135L, 4, new DateTime(2025, 5, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), 68L, 80.00m, new DateTime(2025, 5, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7797), "5" },
                    { 136L, 3, new DateTime(2025, 5, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), 68L, 60.00m, new DateTime(2025, 5, 8, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7798), "6" },
                    { 137L, 4, new DateTime(2025, 5, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), 69L, 80.00m, new DateTime(2025, 5, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7800), "5" },
                    { 138L, 3, new DateTime(2025, 5, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), 69L, 60.00m, new DateTime(2025, 5, 9, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7801), "6" },
                    { 139L, 4, new DateTime(2025, 5, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), 70L, 80.00m, new DateTime(2025, 5, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7802), "5" },
                    { 140L, 3, new DateTime(2025, 5, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), 70L, 60.00m, new DateTime(2025, 5, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7804), "6" },
                    { 141L, 4, new DateTime(2025, 5, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), 71L, 80.00m, new DateTime(2025, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7805), "5" },
                    { 142L, 3, new DateTime(2025, 5, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), 71L, 60.00m, new DateTime(2025, 5, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7806), "6" },
                    { 143L, 4, new DateTime(2025, 5, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), 72L, 80.00m, new DateTime(2025, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7819), "5" },
                    { 144L, 3, new DateTime(2025, 5, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), 72L, 60.00m, new DateTime(2025, 5, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7820), "6" },
                    { 145L, 4, new DateTime(2025, 5, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), 73L, 80.00m, new DateTime(2025, 5, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7822), "5" },
                    { 146L, 3, new DateTime(2025, 5, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), 73L, 60.00m, new DateTime(2025, 5, 13, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7823), "6" },
                    { 147L, 4, new DateTime(2025, 5, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), 74L, 80.00m, new DateTime(2025, 5, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7824), "5" },
                    { 148L, 3, new DateTime(2025, 5, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), 74L, 60.00m, new DateTime(2025, 5, 14, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7825), "6" },
                    { 149L, 4, new DateTime(2025, 5, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), 75L, 80.00m, new DateTime(2025, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7827), "5" },
                    { 150L, 3, new DateTime(2025, 5, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), 75L, 60.00m, new DateTime(2025, 5, 15, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7828), "6" },
                    { 151L, 4, new DateTime(2025, 5, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), 76L, 80.00m, new DateTime(2025, 5, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7829), "5" },
                    { 152L, 3, new DateTime(2025, 5, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), 76L, 60.00m, new DateTime(2025, 5, 16, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7830), "6" },
                    { 153L, 4, new DateTime(2025, 5, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), 77L, 80.00m, new DateTime(2025, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7832), "5" },
                    { 154L, 3, new DateTime(2025, 5, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), 77L, 60.00m, new DateTime(2025, 5, 17, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7833), "6" },
                    { 155L, 4, new DateTime(2025, 5, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), 78L, 80.00m, new DateTime(2025, 5, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7834), "5" },
                    { 156L, 3, new DateTime(2025, 5, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), 78L, 60.00m, new DateTime(2025, 5, 18, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7835), "6" },
                    { 157L, 4, new DateTime(2025, 5, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), 79L, 80.00m, new DateTime(2025, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7837), "5" },
                    { 158L, 3, new DateTime(2025, 5, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), 79L, 60.00m, new DateTime(2025, 5, 19, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7838), "6" },
                    { 159L, 4, new DateTime(2025, 5, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), 80L, 80.00m, new DateTime(2025, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7839), "5" },
                    { 160L, 3, new DateTime(2025, 5, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), 80L, 60.00m, new DateTime(2025, 5, 20, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7840), "6" },
                    { 161L, 4, new DateTime(2025, 5, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), 81L, 80.00m, new DateTime(2025, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7842), "5" },
                    { 162L, 3, new DateTime(2025, 5, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), 81L, 60.00m, new DateTime(2025, 5, 21, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7843), "6" },
                    { 163L, 4, new DateTime(2025, 5, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), 82L, 80.00m, new DateTime(2025, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7844), "5" },
                    { 164L, 3, new DateTime(2025, 5, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), 82L, 60.00m, new DateTime(2025, 5, 22, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7845), "6" },
                    { 165L, 4, new DateTime(2025, 5, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), 83L, 80.00m, new DateTime(2025, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7847), "5" },
                    { 166L, 3, new DateTime(2025, 5, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), 83L, 60.00m, new DateTime(2025, 5, 23, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7848), "6" },
                    { 167L, 4, new DateTime(2025, 5, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), 84L, 80.00m, new DateTime(2025, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7849), "5" },
                    { 168L, 3, new DateTime(2025, 5, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), 84L, 60.00m, new DateTime(2025, 5, 24, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7851), "6" },
                    { 169L, 4, new DateTime(2025, 5, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), 85L, 80.00m, new DateTime(2025, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7852), "5" },
                    { 170L, 3, new DateTime(2025, 5, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), 85L, 60.00m, new DateTime(2025, 5, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7853), "6" },
                    { 171L, 4, new DateTime(2025, 5, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), 86L, 80.00m, new DateTime(2025, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7854), "5" },
                    { 172L, 3, new DateTime(2025, 5, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), 86L, 60.00m, new DateTime(2025, 5, 26, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7855), "6" },
                    { 173L, 4, new DateTime(2025, 5, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), 87L, 80.00m, new DateTime(2025, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7866), "5" },
                    { 174L, 3, new DateTime(2025, 5, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), 87L, 60.00m, new DateTime(2025, 5, 27, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7867), "6" },
                    { 175L, 4, new DateTime(2025, 5, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), 88L, 80.00m, new DateTime(2025, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7869), "5" },
                    { 176L, 3, new DateTime(2025, 5, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), 88L, 60.00m, new DateTime(2025, 5, 28, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7870), "6" },
                    { 177L, 4, new DateTime(2025, 5, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), 89L, 80.00m, new DateTime(2025, 5, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7871), "5" },
                    { 178L, 3, new DateTime(2025, 5, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), 89L, 60.00m, new DateTime(2025, 5, 29, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7873), "6" },
                    { 179L, 4, new DateTime(2025, 5, 29, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 10, 15, 0, 0, DateTimeKind.Unspecified), 90L, 80.00m, new DateTime(2025, 5, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7874), "5" },
                    { 180L, 3, new DateTime(2025, 5, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), 90L, 60.00m, new DateTime(2025, 5, 30, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7875), "6" },
                    { 181L, 4, new DateTime(2025, 5, 30, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 10, 15, 0, 0, DateTimeKind.Unspecified), 91L, 80.00m, new DateTime(2025, 5, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7877), "5" },
                    { 182L, 3, new DateTime(2025, 5, 31, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 31, 9, 45, 0, 0, DateTimeKind.Unspecified), 91L, 60.00m, new DateTime(2025, 5, 31, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7878), "6" },
                    { 183L, 4, new DateTime(2025, 5, 31, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 31, 10, 15, 0, 0, DateTimeKind.Unspecified), 92L, 80.00m, new DateTime(2025, 5, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7879), "5" },
                    { 184L, 3, new DateTime(2025, 6, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 92L, 60.00m, new DateTime(2025, 6, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7881), "6" },
                    { 185L, 4, new DateTime(2025, 6, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 93L, 80.00m, new DateTime(2025, 6, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7882), "5" },
                    { 186L, 3, new DateTime(2025, 6, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 93L, 60.00m, new DateTime(2025, 6, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7883), "6" },
                    { 187L, 4, new DateTime(2025, 6, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 94L, 80.00m, new DateTime(2025, 6, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7884), "5" },
                    { 188L, 3, new DateTime(2025, 6, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), 94L, 60.00m, new DateTime(2025, 6, 3, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7885), "6" },
                    { 189L, 4, new DateTime(2025, 6, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), 95L, 80.00m, new DateTime(2025, 6, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7887), "5" },
                    { 190L, 3, new DateTime(2025, 6, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), 95L, 60.00m, new DateTime(2025, 6, 4, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7888), "6" },
                    { 191L, 4, new DateTime(2025, 6, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), 96L, 80.00m, new DateTime(2025, 6, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7889), "5" },
                    { 192L, 3, new DateTime(2025, 6, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), 96L, 60.00m, new DateTime(2025, 6, 5, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7890), "6" },
                    { 193L, 4, new DateTime(2025, 6, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), 97L, 80.00m, new DateTime(2025, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7892), "5" },
                    { 194L, 3, new DateTime(2025, 6, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), 97L, 60.00m, new DateTime(2025, 6, 6, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7893), "6" },
                    { 195L, 4, new DateTime(2025, 6, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), 98L, 80.00m, new DateTime(2025, 6, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7894), "5" },
                    { 196L, 3, new DateTime(2025, 6, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), 98L, 60.00m, new DateTime(2025, 6, 7, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7896), "6" },
                    { 197L, 4, new DateTime(2025, 6, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), 99L, 80.00m, new DateTime(2025, 6, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7897), "5" },
                    { 198L, 3, new DateTime(2025, 6, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), 99L, 60.00m, new DateTime(2025, 6, 8, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7898), "6" },
                    { 199L, 4, new DateTime(2025, 6, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), 100L, 80.00m, new DateTime(2025, 6, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7900), "5" },
                    { 200L, 3, new DateTime(2025, 6, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), 100L, 60.00m, new DateTime(2025, 6, 9, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7901), "6" },
                    { 201L, 4, new DateTime(2025, 6, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), 101L, 80.00m, new DateTime(2025, 6, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7903), "5" },
                    { 202L, 3, new DateTime(2025, 6, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), 101L, 60.00m, new DateTime(2025, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7904), "6" },
                    { 203L, 4, new DateTime(2025, 6, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), 102L, 80.00m, new DateTime(2025, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7905), "5" },
                    { 204L, 3, new DateTime(2025, 6, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), 102L, 60.00m, new DateTime(2025, 6, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7906), "6" },
                    { 205L, 4, new DateTime(2025, 6, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), 103L, 80.00m, new DateTime(2025, 6, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7908), "5" },
                    { 206L, 3, new DateTime(2025, 6, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), 103L, 60.00m, new DateTime(2025, 6, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7909), "6" },
                    { 207L, 4, new DateTime(2025, 6, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), 104L, 80.00m, new DateTime(2025, 6, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7910), "5" },
                    { 208L, 3, new DateTime(2025, 6, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), 104L, 60.00m, new DateTime(2025, 6, 13, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7911), "6" },
                    { 209L, 4, new DateTime(2025, 6, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), 105L, 80.00m, new DateTime(2025, 6, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7913), "5" },
                    { 210L, 3, new DateTime(2025, 6, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), 105L, 60.00m, new DateTime(2025, 6, 14, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7914), "6" },
                    { 211L, 4, new DateTime(2025, 6, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), 106L, 80.00m, new DateTime(2025, 6, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7926), "5" },
                    { 212L, 3, new DateTime(2025, 6, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), 106L, 60.00m, new DateTime(2025, 6, 15, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7927), "6" },
                    { 213L, 4, new DateTime(2025, 6, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), 107L, 80.00m, new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7929), "5" },
                    { 214L, 3, new DateTime(2025, 6, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), 107L, 60.00m, new DateTime(2025, 6, 16, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7930), "6" },
                    { 215L, 4, new DateTime(2025, 6, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), 108L, 80.00m, new DateTime(2025, 6, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7931), "5" },
                    { 216L, 3, new DateTime(2025, 6, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), 108L, 60.00m, new DateTime(2025, 6, 17, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7932), "6" },
                    { 217L, 4, new DateTime(2025, 6, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), 109L, 80.00m, new DateTime(2025, 6, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7934), "5" },
                    { 218L, 3, new DateTime(2025, 6, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), 109L, 60.00m, new DateTime(2025, 6, 18, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7935), "6" },
                    { 219L, 4, new DateTime(2025, 6, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), 110L, 80.00m, new DateTime(2025, 6, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7936), "5" },
                    { 220L, 3, new DateTime(2025, 6, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), 110L, 60.00m, new DateTime(2025, 6, 19, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7938), "6" },
                    { 221L, 4, new DateTime(2025, 6, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), 111L, 80.00m, new DateTime(2025, 6, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7939), "5" },
                    { 222L, 3, new DateTime(2025, 6, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), 111L, 60.00m, new DateTime(2025, 6, 20, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7940), "6" },
                    { 223L, 4, new DateTime(2025, 6, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), 112L, 80.00m, new DateTime(2025, 6, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7941), "5" },
                    { 224L, 3, new DateTime(2025, 6, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), 112L, 60.00m, new DateTime(2025, 6, 21, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7942), "6" },
                    { 225L, 4, new DateTime(2025, 6, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), 113L, 80.00m, new DateTime(2025, 6, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7944), "5" },
                    { 226L, 3, new DateTime(2025, 6, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), 113L, 60.00m, new DateTime(2025, 6, 22, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7945), "6" },
                    { 227L, 4, new DateTime(2025, 6, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), 114L, 80.00m, new DateTime(2025, 6, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7946), "5" },
                    { 228L, 3, new DateTime(2025, 6, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), 114L, 60.00m, new DateTime(2025, 6, 23, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7947), "6" },
                    { 229L, 4, new DateTime(2025, 6, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), 115L, 80.00m, new DateTime(2025, 6, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7949), "5" },
                    { 230L, 3, new DateTime(2025, 6, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), 115L, 60.00m, new DateTime(2025, 6, 24, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7950), "6" },
                    { 231L, 4, new DateTime(2025, 6, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), 116L, 80.00m, new DateTime(2025, 6, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7951), "5" },
                    { 232L, 3, new DateTime(2025, 6, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), 116L, 60.00m, new DateTime(2025, 6, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7953), "6" },
                    { 233L, 4, new DateTime(2025, 6, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), 117L, 80.00m, new DateTime(2025, 6, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7954), "5" },
                    { 234L, 3, new DateTime(2025, 6, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), 117L, 60.00m, new DateTime(2025, 6, 26, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7955), "6" },
                    { 235L, 4, new DateTime(2025, 6, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), 118L, 80.00m, new DateTime(2025, 6, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7956), "5" },
                    { 236L, 3, new DateTime(2025, 6, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), 118L, 60.00m, new DateTime(2025, 6, 27, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7958), "6" },
                    { 237L, 4, new DateTime(2025, 6, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), 119L, 80.00m, new DateTime(2025, 6, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7959), "5" },
                    { 238L, 3, new DateTime(2025, 6, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), 119L, 60.00m, new DateTime(2025, 6, 28, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7960), "6" },
                    { 239L, 4, new DateTime(2025, 6, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), 120L, 80.00m, new DateTime(2025, 6, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7962), "5" },
                    { 240L, 3, new DateTime(2025, 6, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), 120L, 60.00m, new DateTime(2025, 6, 29, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7963), "6" },
                    { 241L, 4, new DateTime(2025, 6, 29, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 29, 10, 15, 0, 0, DateTimeKind.Unspecified), 121L, 80.00m, new DateTime(2025, 6, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7964), "5" },
                    { 242L, 3, new DateTime(2025, 6, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), 121L, 60.00m, new DateTime(2025, 6, 30, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7965), "6" },
                    { 243L, 4, new DateTime(2025, 6, 30, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 10, 15, 0, 0, DateTimeKind.Unspecified), 122L, 80.00m, new DateTime(2025, 6, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7967), "5" },
                    { 244L, 3, new DateTime(2025, 7, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 122L, 60.00m, new DateTime(2025, 7, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7968), "6" },
                    { 245L, 4, new DateTime(2025, 7, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 123L, 80.00m, new DateTime(2025, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7969), "5" },
                    { 246L, 3, new DateTime(2025, 7, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 123L, 60.00m, new DateTime(2025, 7, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7970), "6" },
                    { 247L, 4, new DateTime(2025, 7, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 124L, 80.00m, new DateTime(2025, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7972), "5" },
                    { 248L, 3, new DateTime(2025, 7, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), 124L, 60.00m, new DateTime(2025, 7, 3, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7973), "6" },
                    { 249L, 4, new DateTime(2025, 7, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 3, 10, 15, 0, 0, DateTimeKind.Unspecified), 125L, 80.00m, new DateTime(2025, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7974), "5" },
                    { 250L, 3, new DateTime(2025, 7, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), 125L, 60.00m, new DateTime(2025, 7, 4, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7975), "6" },
                    { 251L, 4, new DateTime(2025, 7, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), 126L, 80.00m, new DateTime(2025, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7977), "5" },
                    { 252L, 3, new DateTime(2025, 7, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), 126L, 60.00m, new DateTime(2025, 7, 5, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7978), "6" },
                    { 253L, 4, new DateTime(2025, 7, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 5, 10, 15, 0, 0, DateTimeKind.Unspecified), 127L, 80.00m, new DateTime(2025, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7979), "5" },
                    { 254L, 3, new DateTime(2025, 7, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), 127L, 60.00m, new DateTime(2025, 7, 6, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7980), "6" },
                    { 255L, 4, new DateTime(2025, 7, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 6, 10, 15, 0, 0, DateTimeKind.Unspecified), 128L, 80.00m, new DateTime(2025, 7, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7982), "5" },
                    { 256L, 3, new DateTime(2025, 7, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), 128L, 60.00m, new DateTime(2025, 7, 7, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7983), "6" },
                    { 257L, 4, new DateTime(2025, 7, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 7, 10, 15, 0, 0, DateTimeKind.Unspecified), 129L, 80.00m, new DateTime(2025, 7, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7984), "5" },
                    { 258L, 3, new DateTime(2025, 7, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 8, 9, 45, 0, 0, DateTimeKind.Unspecified), 129L, 60.00m, new DateTime(2025, 7, 8, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7998), "6" },
                    { 259L, 4, new DateTime(2025, 7, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), 130L, 80.00m, new DateTime(2025, 7, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(7999), "5" },
                    { 260L, 3, new DateTime(2025, 7, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), 130L, 60.00m, new DateTime(2025, 7, 9, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8001), "6" },
                    { 261L, 4, new DateTime(2025, 7, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), 131L, 80.00m, new DateTime(2025, 7, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8002), "5" },
                    { 262L, 3, new DateTime(2025, 7, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), 131L, 60.00m, new DateTime(2025, 7, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8003), "6" },
                    { 263L, 4, new DateTime(2025, 7, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 10, 15, 0, 0, DateTimeKind.Unspecified), 132L, 80.00m, new DateTime(2025, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8005), "5" },
                    { 264L, 3, new DateTime(2025, 7, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 11, 9, 45, 0, 0, DateTimeKind.Unspecified), 132L, 60.00m, new DateTime(2025, 7, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8006), "6" },
                    { 265L, 4, new DateTime(2025, 7, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 11, 10, 15, 0, 0, DateTimeKind.Unspecified), 133L, 80.00m, new DateTime(2025, 7, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8007), "5" },
                    { 266L, 3, new DateTime(2025, 7, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), 133L, 60.00m, new DateTime(2025, 7, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8008), "6" },
                    { 267L, 4, new DateTime(2025, 7, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 10, 15, 0, 0, DateTimeKind.Unspecified), 134L, 80.00m, new DateTime(2025, 7, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8010), "5" },
                    { 268L, 3, new DateTime(2025, 7, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), 134L, 60.00m, new DateTime(2025, 7, 13, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8011), "6" },
                    { 269L, 4, new DateTime(2025, 7, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 10, 15, 0, 0, DateTimeKind.Unspecified), 135L, 80.00m, new DateTime(2025, 7, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8012), "5" },
                    { 270L, 3, new DateTime(2025, 7, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 9, 45, 0, 0, DateTimeKind.Unspecified), 135L, 60.00m, new DateTime(2025, 7, 14, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8013), "6" },
                    { 271L, 4, new DateTime(2025, 7, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), 136L, 80.00m, new DateTime(2025, 7, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8015), "5" },
                    { 272L, 3, new DateTime(2025, 7, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 15, 9, 45, 0, 0, DateTimeKind.Unspecified), 136L, 60.00m, new DateTime(2025, 7, 15, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8016), "6" },
                    { 273L, 4, new DateTime(2025, 7, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 15, 10, 15, 0, 0, DateTimeKind.Unspecified), 137L, 80.00m, new DateTime(2025, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8017), "5" },
                    { 274L, 3, new DateTime(2025, 7, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 16, 9, 45, 0, 0, DateTimeKind.Unspecified), 137L, 60.00m, new DateTime(2025, 7, 16, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8018), "6" },
                    { 275L, 4, new DateTime(2025, 7, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 16, 10, 15, 0, 0, DateTimeKind.Unspecified), 138L, 80.00m, new DateTime(2025, 7, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8020), "5" },
                    { 276L, 3, new DateTime(2025, 7, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 17, 9, 45, 0, 0, DateTimeKind.Unspecified), 138L, 60.00m, new DateTime(2025, 7, 17, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8021), "6" },
                    { 277L, 4, new DateTime(2025, 7, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 17, 10, 15, 0, 0, DateTimeKind.Unspecified), 139L, 80.00m, new DateTime(2025, 7, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8022), "5" },
                    { 278L, 3, new DateTime(2025, 7, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 18, 9, 45, 0, 0, DateTimeKind.Unspecified), 139L, 60.00m, new DateTime(2025, 7, 18, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8023), "6" },
                    { 279L, 4, new DateTime(2025, 7, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 18, 10, 15, 0, 0, DateTimeKind.Unspecified), 140L, 80.00m, new DateTime(2025, 7, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8025), "5" },
                    { 280L, 3, new DateTime(2025, 7, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 19, 9, 45, 0, 0, DateTimeKind.Unspecified), 140L, 60.00m, new DateTime(2025, 7, 19, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8026), "6" },
                    { 281L, 4, new DateTime(2025, 7, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), 141L, 80.00m, new DateTime(2025, 7, 19, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8027), "5" },
                    { 282L, 3, new DateTime(2025, 7, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 9, 45, 0, 0, DateTimeKind.Unspecified), 141L, 60.00m, new DateTime(2025, 7, 20, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8028), "6" },
                    { 283L, 4, new DateTime(2025, 7, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), 142L, 80.00m, new DateTime(2025, 7, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8030), "5" },
                    { 284L, 3, new DateTime(2025, 7, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 21, 9, 45, 0, 0, DateTimeKind.Unspecified), 142L, 60.00m, new DateTime(2025, 7, 21, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8031), "6" },
                    { 285L, 4, new DateTime(2025, 7, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 21, 10, 15, 0, 0, DateTimeKind.Unspecified), 143L, 80.00m, new DateTime(2025, 7, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8032), "5" },
                    { 286L, 3, new DateTime(2025, 7, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 22, 9, 45, 0, 0, DateTimeKind.Unspecified), 143L, 60.00m, new DateTime(2025, 7, 22, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8033), "6" },
                    { 287L, 4, new DateTime(2025, 7, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 22, 10, 15, 0, 0, DateTimeKind.Unspecified), 144L, 80.00m, new DateTime(2025, 7, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8035), "5" },
                    { 288L, 3, new DateTime(2025, 7, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), 144L, 60.00m, new DateTime(2025, 7, 23, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8036), "6" },
                    { 289L, 4, new DateTime(2025, 7, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 23, 10, 15, 0, 0, DateTimeKind.Unspecified), 145L, 80.00m, new DateTime(2025, 7, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8037), "5" },
                    { 290L, 3, new DateTime(2025, 7, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), 145L, 60.00m, new DateTime(2025, 7, 24, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8038), "6" },
                    { 291L, 4, new DateTime(2025, 7, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), 146L, 80.00m, new DateTime(2025, 7, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8040), "5" },
                    { 292L, 3, new DateTime(2025, 7, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), 146L, 60.00m, new DateTime(2025, 7, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8041), "6" },
                    { 293L, 4, new DateTime(2025, 7, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), 147L, 80.00m, new DateTime(2025, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8042), "5" },
                    { 294L, 3, new DateTime(2025, 7, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 26, 9, 45, 0, 0, DateTimeKind.Unspecified), 147L, 60.00m, new DateTime(2025, 7, 26, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8043), "6" },
                    { 295L, 4, new DateTime(2025, 7, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), 148L, 80.00m, new DateTime(2025, 7, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8045), "5" },
                    { 296L, 3, new DateTime(2025, 7, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 27, 9, 45, 0, 0, DateTimeKind.Unspecified), 148L, 60.00m, new DateTime(2025, 7, 27, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8046), "6" },
                    { 297L, 4, new DateTime(2025, 7, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 27, 10, 15, 0, 0, DateTimeKind.Unspecified), 149L, 80.00m, new DateTime(2025, 7, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8047), "5" },
                    { 298L, 3, new DateTime(2025, 7, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), 149L, 60.00m, new DateTime(2025, 7, 28, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8048), "6" },
                    { 299L, 4, new DateTime(2025, 7, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 28, 10, 15, 0, 0, DateTimeKind.Unspecified), 150L, 80.00m, new DateTime(2025, 7, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8050), "5" },
                    { 300L, 3, new DateTime(2025, 7, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 29, 9, 45, 0, 0, DateTimeKind.Unspecified), 150L, 60.00m, new DateTime(2025, 7, 29, 9, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2025, 11, 7, 21, 10, 18, 568, DateTimeKind.Local).AddTicks(8051), "6" }
                });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 1L,
                column: "UserId",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 2L,
                column: "UserId",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 5L,
                column: "UserId",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 6L,
                column: "UserId",
                value: "7");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 7L,
                column: "UserId",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 8L,
                column: "UserId",
                value: "7");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 9L,
                column: "UserId",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 10L,
                column: "UserId",
                value: "7");

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 1L,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 499000m, "5" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 2L,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 509000m, "5" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 3L,
                columns: new[] { "Amount", "Description", "Status", "UserId" },
                values: new object[] { 519000m, "Purchase course 3", 1, "5" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 4L,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 529000m, "5" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 5L,
                columns: new[] { "Amount", "Description", "Status", "UserId" },
                values: new object[] { 539000m, "Purchase course 5", 1, "5" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 6L,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 549000m, "5" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "mentor-role", "3" },
                    { "mentor-role", "4" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c502fc3c-fb4c-4402-b4ef-554eb38175b6", "AQAAAAIAAYagAAAAENHJQtL4Lmow1IaQYgPRub/pdeps2D97CjvzxZZaDnW7kUf4oZ4IjJy6kfGxLwDypw==", "6a018d53-ab39-4732-9d07-8cff1e31de88", new DateTime(2025, 11, 7, 21, 10, 15, 677, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "437390b0-d016-4998-8652-360866ea08cd", "AQAAAAIAAYagAAAAEKdtJleDIhq9br0Ycgro5Wp1wK0J119f+2J2KHqg/EHUXl5SNBoBD1geyKDHSydoCw==", "01c0f206-d19c-46da-bfb7-c60ebd5ed536", new DateTime(2025, 11, 7, 21, 10, 16, 206, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "86826894-3f2e-470f-ab05-57051572d54f", "AQAAAAIAAYagAAAAEM1ly859KKPu6vINi3XbtC7UcXDNsLnZ+IxKQbYjcUQwQTV44M7ug6OBi0jmDDe/AA==", "aafb8ca8-5ca5-448e-a150-c7e7c24bc4d8", new DateTime(2025, 11, 7, 21, 10, 16, 266, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "aa773613-5041-40a4-9292-021fac18f869", "AQAAAAIAAYagAAAAEL7oC/VUFaB4EiLWlIMv1XRW9DmI0DzqnbY1yoioycfuPU/Z0tUgluIa4aKSQQ7f6A==", "f2cd4d6d-744b-4124-8452-16811034f51e", new DateTime(2025, 11, 7, 21, 10, 16, 322, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3ba795c3-f34f-4ab9-97d7-013e111cc6a6", "AQAAAAIAAYagAAAAEP5hl1Qgb/c1WghMrjZYE6ZLQuPKFwI8ob8XQ22ojzJu6DEU+QyYFZlvh2pj6XrdMQ==", "75096948-c138-4a22-9e41-fa004debfcb2", new DateTime(2025, 11, 7, 21, 10, 16, 379, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "39a1359c-06a1-4c05-b18f-8134e6eeeb59", "AQAAAAIAAYagAAAAEJOm+V02LBqpxjVZzee5dC4s8fR0iUYBgDvu66mx6aXtTU/MBrw2kAoUoVMVni7w8A==", "a2cc8f2a-c7eb-4c78-9e5b-fba215e5117b", new DateTime(2025, 11, 7, 21, 10, 16, 434, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "eca01cd0-a740-4f26-8c68-0f1bd34dc186", "AQAAAAIAAYagAAAAEOqQOU5x0LMyQPzCIxAs4dWi9vNpv08DEIQtKbU7WuqqfqB9Lkt4HS9mRMtsN1/rsQ==", "e09721ea-01fa-4c7f-b616-643bdf994911", new DateTime(2025, 11, 7, 21, 10, 16, 489, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "01cf8552-ead4-42d4-ae35-2dd8f4513cd9", "AQAAAAIAAYagAAAAEB0TR0HV9YwTN2vp3bWzes9CU3QGZ2D451f7Wlc/3cjjBD3HZpoZeQVUDpnX/bsveg==", "44fa4b74-9bcc-4088-9ef3-485cfd1a1868", new DateTime(2025, 11, 7, 21, 10, 16, 548, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0a6564c3-6982-4f2e-b8db-74ba7d2ec2b7", "AQAAAAIAAYagAAAAECieFlIkWcpofNNjYNkjV3Bf9Cl3AsSSNZBQeLL9GBcSio36KqdS+It2fcpV2BHWUw==", "3a6b4192-a1fe-4e29-b890-a4f6594d6e5e", new DateTime(2025, 11, 7, 21, 10, 16, 605, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "16e0f2d3-18d6-432a-8810-b643679db93e", "AQAAAAIAAYagAAAAENchj0JJC3AtbH0t5ITvB3nWT/Asz7G6GXymlSmU5qQ3mPfs4vLUyqdqGXx6HvgYrg==", "d767ceb3-d664-4a70-afb2-38e7960d290d", new DateTime(2025, 11, 7, 21, 10, 16, 661, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "081c9722-1f8f-482e-8850-ef0c85e62343", "AQAAAAIAAYagAAAAEOlS4EE+UxaAGG16YhbNCR0Jo1LECkWnILifxu+E/iW2OxVI55UjEeBNFpiWrkFssA==", "6ef5349a-c21a-44a5-bf3d-c04dc7018422", new DateTime(2025, 11, 7, 21, 10, 16, 719, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "7f4d72e9-010e-4cd1-af97-84dd97bb196e", "mentor1@demo.com", "Demo Mentor1", "MENTOR1@DEMO.COM", "MENTOR1@DEMO.COM", "AQAAAAIAAYagAAAAEItHnZbUCM362YCvqTOMzWnc/NGq5VEKXGBQcDshprAsevKF3QjXMa8zZG2alDj51w==", "f86d7f52-6147-4383-896f-6e04fa9ae275", new DateTime(2025, 11, 7, 21, 10, 15, 733, DateTimeKind.Local).AddTicks(7760), "mentor1@demo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7a0a2152-5caf-42ee-86d6-91af91559300", "AQAAAAIAAYagAAAAEPxy8CMYHg7JPxj1oMFKESKmg63uHxhE9T2LHYsaYoQZFBYQVi7zhObfi0lEabebKg==", "73ec90d1-dd44-4ae4-a6ec-bb5c79cdf8ef", new DateTime(2025, 11, 7, 21, 10, 16, 777, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f6132b1b-18a4-4608-a019-a4a382f76afe", "AQAAAAIAAYagAAAAENOMo0D3oYYPH7D5W8ruylxv3fhJaS8dWi7Ung/jRNgFTjp+hAVP/d0LT8jZLEBy9Q==", "9bf541d3-552c-456f-a205-cf6104b8753c", new DateTime(2025, 11, 7, 21, 10, 16, 833, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "94fa2f16-d2dd-4159-bcb2-9d4b43809003", "AQAAAAIAAYagAAAAEN+dvKFCW/ezQuktEmm5axcm8RZObfeG4Il2N9e8eBqe9izLjLPuCJGDASM68P1ONw==", "99039942-8f81-4de9-b734-604e6ea70530", new DateTime(2025, 11, 7, 21, 10, 16, 890, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "80f5d04a-ed8c-488c-a5a6-437a23c7b180", "AQAAAAIAAYagAAAAECDdLuq0JF/Z9GVbP19g9QAm50dHvoylg2d5nPrtMGfgMTa1Y51hTll71RQcODEPvQ==", "caecd99c-55e6-40cf-b145-a35387f61907", new DateTime(2025, 11, 7, 21, 10, 16, 947, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "62ef8fdb-2b81-44c7-a069-6efc42728c8e", "AQAAAAIAAYagAAAAEOJ/qNhVP0mG81E3kLyWku5p7P1GDBeS4PEj+9e85M0xJfcKT41zt6sEt8UoW7aBYg==", "fc4d9263-fe82-41a7-bde0-18095e00cf16", new DateTime(2025, 11, 7, 21, 10, 17, 4, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b96d0d33-b5fb-4090-bb6b-539007594a3a", "AQAAAAIAAYagAAAAECCoedlnRzH/YHcAswQyq1WrRP3TyknhTdFpg030A6bd8ymkds1SXeSxhJMoGPqy6A==", "c6663975-b19a-4f2e-9be9-b74d2a960264", new DateTime(2025, 11, 7, 21, 10, 17, 60, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "10040faa-5745-4215-bdc6-290c670d095f", "AQAAAAIAAYagAAAAEAESscF3Tx+jMVEWQlt4BHXeyf+W+UItjDsP9de3gClm6oE55DhN7QTD3PDPz2w8Tw==", "3e67ae37-c6be-4947-85b5-bafd59b2fd96", new DateTime(2025, 11, 7, 21, 10, 17, 118, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1d7a771f-4d33-40b8-819c-24b6ae9041ce", "AQAAAAIAAYagAAAAEF9prQShL6M6tjOdH6iH0odld3H7yEVa98UFeh7FLyVb6HXq3Q9AJ1/qel5kh4qXeA==", "48980ab6-7c09-4d06-a535-131194cb67af", new DateTime(2025, 11, 7, 21, 10, 17, 175, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0ee6fc99-f58a-49f2-a631-6c58b7bb0768", "AQAAAAIAAYagAAAAEAG5wDcTWQxgTI/+oXKpUfFDVUN+EtOnUngYJNmr2IYNIwCxl0C1iyvqZ2f6nKWVWQ==", "78ae9bc5-f79c-4627-ae7b-33fbf22ec201", new DateTime(2025, 11, 7, 21, 10, 17, 242, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a8dc3314-dd54-4011-8f79-44832772a727", "AQAAAAIAAYagAAAAEODDNPJ89prCeI/irEFLh/Z60n1Q89Np3LsMy75jbkbVAyYYqda8xdZSrjPfZNCTAg==", "08e4a9ee-c67e-4659-a14f-24087860451c", new DateTime(2025, 11, 7, 21, 10, 17, 302, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/2/200/200", "7ae5072b-f7cb-48ab-a3a6-9a0e1472778f", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1990, 1, 1), "mentor2@demo.com", "Demo Mentor2", "MENTOR2@DEMO.COM", "MENTOR2@DEMO.COM", "AQAAAAIAAYagAAAAENaxT+mU/OCx1UVGH2xmgbKDng7tBlnswUUZG1ryarJLHWlyfU4ALGv7uVmA998RBA==", "0000000001", "5d183b1d-5964-472e-9012-ac621802560e", new DateTime(2025, 11, 7, 21, 10, 15, 788, DateTimeKind.Local).AddTicks(6204), "mentor2@demo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fd9fb56b-1590-4ce6-8ac3-50f46a5c779b", "AQAAAAIAAYagAAAAEM/wLegHt+eiAGgio3Wl3uTUVC/HgQ7zl3D3QZtmPk7JZSsrnVWQ5Bl5VbqxWislrA==", "5092080b-335e-41ff-965e-4f305ad088be", new DateTime(2025, 11, 7, 21, 10, 17, 362, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e2dc93f1-57a4-4d45-a9cd-9f048ecfc53b", "AQAAAAIAAYagAAAAEI1reXU0lsV7DDFkN9HaPkzsNg6dZ80srMPfC7uCPyFxW9HsvLA6XeonjcoJ4470Ew==", "0c841936-6efb-4737-829b-9ccdddcae386", new DateTime(2025, 11, 7, 21, 10, 17, 418, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cc39f9d3-04f0-4d7d-89ee-5d7924e19ede", "AQAAAAIAAYagAAAAENq/hBYN3dZJbKk9p9b36RisrFuqiZFQv8zzcqVo81ndnvYfnqZ10nar6MgT4FmNrQ==", "c67ef83d-7c3b-4901-8452-359e860c719e", new DateTime(2025, 11, 7, 21, 10, 17, 475, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "333fce85-4e18-4a8d-aa8b-2ae2f87d4983", "AQAAAAIAAYagAAAAEMCUnXUoTZs4gW6rkPNMA1OdZ/5r8kxZu4yq6Rzrga6bC7uYfnVRaGJO/4fXie3gzQ==", "2e48c6c2-fbbd-4cf9-ac5f-4e65616ea58d", new DateTime(2025, 11, 7, 21, 10, 17, 536, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0a30c96a-53bd-4a55-a057-a2675880c3b3", "AQAAAAIAAYagAAAAENav5WCaBsaQFJ0B4Kk9FD121sVakVfiLbFniB9spg3oRO9QL9sXP8HH1s+fmsKv+w==", "64df2a63-cdae-4563-a87b-dda3154299ff", new DateTime(2025, 11, 7, 21, 10, 17, 598, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d94dba49-da41-4e84-bcca-7c1a5057d4e8", "AQAAAAIAAYagAAAAEM4ddlKQbETyrwu5r/iA/FCNmlV4InMONRrGk8hK36H/NKmkTEaO5j+kOnAzmSqTRg==", "01654ec1-2f1d-4131-893d-7fba6be87785", new DateTime(2025, 11, 7, 21, 10, 17, 653, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "271a447f-992a-4f7a-922e-9122be127d8d", "AQAAAAIAAYagAAAAEECiQ6vdTlfDMxPm4cklNtNvtfbm+33L95P02MROxaGAQhtQDrZwX0wu7oMI+THvWw==", "9111aff8-447c-40e4-9727-26ef098707a6", new DateTime(2025, 11, 7, 21, 10, 17, 708, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "13b0cf34-ddc3-4036-9d98-6c8349deb2b7", "AQAAAAIAAYagAAAAENMUAckT8hsFf44EuRzyy5Zpf7bpxV2fZQ+EsE4oivTokr030KN+vT9jZKvACsPCUg==", "21d1b0e4-1139-4d98-b28f-4ce0556431b4", new DateTime(2025, 11, 7, 21, 10, 17, 766, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5cbda938-b9bb-4402-8e40-6bc86f5c1807", "AQAAAAIAAYagAAAAEMvxLHq2gN0RiP1Jx2eHCDFeKuK4Es/dCYs/QFhzTxTcilf1LOQhF/iTpBD7PkEXQw==", "52feb848-7546-4100-820d-0abcd17242b5", new DateTime(2025, 11, 7, 21, 10, 17, 820, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "db09a098-9043-4bb4-a2e4-eda8f05b74a0", "AQAAAAIAAYagAAAAEJEn6N52tBqDgJgrS3dpiI9eDA2k4GxM8T+H8oDO+mGZpXQrSMExsKDBMO3Uv9Or4w==", "69cb569c-12bc-4b12-908f-1108097d3a3c", new DateTime(2025, 11, 7, 21, 10, 17, 878, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/2/200/200", "44daf5ce-3628-42d2-beb3-9ab71e12c2a0", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1990, 1, 1), "mentor3@demo.com", "Demo Mentor3", true, "MENTOR3@DEMO.COM", "MENTOR3@DEMO.COM", "AQAAAAIAAYagAAAAEM6jPnmBRMbPzIO3LYMqS3RxPgGaGmCUDI+Kkt6ne/LVMZoOGasHUqLZDKGt6Q0//Q==", "0000000001", "795a1c1c-dfd2-48b2-b6ec-b008b64b0c53", new DateTime(2025, 11, 7, 21, 10, 15, 852, DateTimeKind.Local).AddTicks(7343), "mentor3@demo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a7bd48dd-9cd2-466d-a902-9ffebcb4eeee", "AQAAAAIAAYagAAAAEJiPo63teQsrDiZpbmHrbhXPhEZDFNN4Jp11tsuXe7vKk73BzOBdZxQlj2NMITEiWQ==", "67dcfad6-2496-4358-89ff-98a430bd29d5", new DateTime(2025, 11, 7, 21, 10, 17, 932, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b97d6d09-d781-4074-920b-818b450135bd", "AQAAAAIAAYagAAAAEP5m0se34eGkV7G4/zosCOrO8flvTF7YVYKc7+FWfZYpP03R/BkOH9ZcaBBEJ9+jWg==", "60cd4c7b-7788-43fe-9960-66b9ac378cb3", new DateTime(2025, 11, 7, 21, 10, 17, 987, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6094261f-07b3-4914-a99e-083d5e48fd59", "AQAAAAIAAYagAAAAEKiXX2dqWAHhAMMuOH2Gh/vTUhRp7IW6U8kX0vBpByp8mrm0GLpoEiSVtp1fFN2xIw==", "67ef11a2-c935-49fc-92ea-773027e8a664", new DateTime(2025, 11, 7, 21, 10, 18, 42, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "044ff84f-6154-476b-9317-f7cdf1437eef", "AQAAAAIAAYagAAAAEAjBbHO40/MH/GWBYZo3eKT/v6EVVj7ZCbkZq+2304fpyc/T8LN14RmPYKJClYzqlw==", "2bc636e3-dab8-4348-92b0-41b77d8d3b29", new DateTime(2025, 11, 7, 21, 10, 18, 102, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4e543cec-8594-4cb5-b1d9-afc19cd62076", "AQAAAAIAAYagAAAAED8Cysy9pRXWS36Qdh+Fupwu+Q818ei7GjmRWwIlZgWFAyLtYej96K+XHFysAxtMzQ==", "1f33c33c-0d53-44a5-b8d5-b07cb259dd91", new DateTime(2025, 11, 7, 21, 10, 18, 157, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f6a1b3cc-8e30-4ef1-b042-8bbbe78c1e0e", "AQAAAAIAAYagAAAAEJcjAcYTS0hs3/9YWYOu6n7q3twB3yOB/+3hS3r8ha4odIrCqJT9wT+EpsMdvwEEnA==", "8514b67e-cdb9-4045-a535-ba47bf465f2e", new DateTime(2025, 11, 7, 21, 10, 18, 215, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "20eb590e-e17e-4172-9232-c1fa2f37072d", "AQAAAAIAAYagAAAAEK8i3tTaFR/CYh/nR01vy9cSCHif9ryYVMRuyMhHAeAACRCJtx8L2fGzNJnYYPnytA==", "f19ea5c8-1dc9-489a-b804-0c911e24df17", new DateTime(2025, 11, 7, 21, 10, 18, 271, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e898f1f6-1ba9-46d1-84cd-349af0576e3b", "AQAAAAIAAYagAAAAEKIH6gwrkiN0vs/S8hizlSXnu2U/7H3Oo5bGOhVkE4ypQUMdIwfwSK3Gksy7MUwcGg==", "1635b70a-fa00-4375-9191-e2b15c89bb49", new DateTime(2025, 11, 7, 21, 10, 18, 328, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "00cc3ebc-03aa-427b-a124-70ac17a949b2", "AQAAAAIAAYagAAAAEGv0fhbS2zS8Qm+vbH5U9oM1INd91rOJBHYicvmuumXVenMKXw1xnyi8n7WBZwA6UQ==", "624822f0-42aa-4111-8cb2-4a2ffba63f31", new DateTime(2025, 11, 7, 21, 10, 18, 387, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "289ee691-21f9-457f-9a7c-594e1dd7e3b4", "AQAAAAIAAYagAAAAEFeXyrSif6j8GWvSKTPZEiWR/01I7M8rVB3HzSoAC+9manPwVo82Y8TnKQKXKprVdQ==", "3fe06fe8-937a-42c3-92ac-a6ca7387c96f", new DateTime(2025, 11, 7, 21, 10, 18, 445, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/mentee1/200/200", "e583ed59-5e7a-4a0f-84a1-19be04f54571", new DateOnly(1998, 3, 3), "mentee1@example.com", "Mentee One", "MENTEE1@EXAMPLE.COM", "MENTEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB+uGmRvsgHbd1g3aABHEpa080fGSHB4xGJUXwxMylQ974bzSugVIXS/J2fkjBy87g==", "0900000003", "051ede5d-3420-4592-9fac-8a729c1dd925", new DateTime(2025, 11, 7, 21, 10, 15, 912, DateTimeKind.Local).AddTicks(3052), "mentee1@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ebecf125-571a-4d35-8530-0ec93dc7be5c", "AQAAAAIAAYagAAAAEKKzopQ6OvxljFdh9/gPX/782SG1p+UPBRrBiqeCCFYDk7TyOEIjoAnxBjsQxgAuvw==", "07d987c0-3926-4029-9371-30f048bccf47", new DateTime(2025, 11, 7, 21, 10, 18, 510, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/mentee2/200/200", "12f8a0f0-67ae-4e86-baf7-70efe6932365", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1997, 4, 4), "mentee2@example.com", "Mentee Two", false, "MENTEE2@EXAMPLE.COM", "MENTEE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOYm8K0FlBi6thYM1qiXEDIg7bZgVtsAkzkY1lFI5h7zGyl06PlQ+q3sR2ABnB96bw==", "0900000004", "2b9eb6ec-af86-4d13-9e27-c9c31833701d", new DateTime(2025, 11, 7, 21, 10, 15, 967, DateTimeKind.Local).AddTicks(235), "mentee2@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/mentee3/200/200", "353a85b5-63a6-4df4-a690-a876aae56498", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1996, 5, 5), "mentee3@example.com", "Mentee Three", true, "MENTEE3@EXAMPLE.COM", "MENTEE3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDFizSgQWDGSvgBkvvP/sjwUUXO0gjVYJmcgcaq/r/uwCb+aPKncuk6kxqaht6QiDw==", "0900000005", "4213808e-ba5e-45b4-9823-6ba1a0bbb83e", new DateTime(2025, 11, 7, 21, 10, 16, 21, DateTimeKind.Local).AddTicks(6095), "mentee3@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8959317b-349b-4e29-8ca7-a4b7fb2b0300", "AQAAAAIAAYagAAAAEEKyNq5IkfQhtehc42RVKpluXius05KIXeIGTMhkYjOkiWCtBC340u6pzY5Yo4shPA==", "0dce450b-e164-4b25-839c-8b19105a0ce4", new DateTime(2025, 11, 7, 21, 10, 16, 81, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c2ab6806-89e7-4e82-b218-291b0781e244", "AQAAAAIAAYagAAAAEG1Zw9cXHmgmRFhZz9nf/CHZ5tvh3Ea4l5BizA+Ubv8fl9Mzgi0V2IB/5Davula79g==", "f0090e68-5d61-4c2c-9b40-d7e03a5dcbdf", new DateTime(2025, 11, 7, 21, 10, 16, 142, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "6" },
                column: "CreatedAt",
                value: new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "WishLists",
                columns: new[] { "CourseId", "UserId", "CreatedAt" },
                values: new object[,]
                {
                    { 2L, "6", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "6", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "6", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 450L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 453L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 454L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 455L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 456L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 457L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 458L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 460L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 463L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 467L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 469L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 470L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 473L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 474L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 475L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 476L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 477L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 478L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 479L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 480L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 481L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 482L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 483L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 484L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 485L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 486L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 487L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 488L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 489L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 490L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 491L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 492L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 493L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 494L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 495L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 496L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 497L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 498L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 499L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 500L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 503L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 504L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 505L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 506L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 507L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 508L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 509L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 510L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 511L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 512L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 513L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 514L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 515L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 516L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 517L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 518L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 519L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 520L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 521L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 522L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 523L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 524L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 525L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 526L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 527L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 528L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 529L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 530L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 531L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 532L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 533L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 534L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 535L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 536L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 537L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 538L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 539L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 540L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 541L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 542L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 543L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 544L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 545L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 546L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 547L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 548L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 549L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 550L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 551L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 552L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 553L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 554L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 555L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 556L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 557L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 558L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 559L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 560L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 561L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 562L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 563L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 564L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 565L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 566L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 567L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 568L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 569L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 570L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 571L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 572L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 573L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 574L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 575L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 576L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 577L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 578L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 579L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 580L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 581L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 582L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 583L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 584L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 585L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 586L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 587L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 588L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 589L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 590L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 591L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 592L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 593L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 594L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 595L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 596L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 597L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 598L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 599L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 600L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 601L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 602L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 603L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 604L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 605L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 606L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 607L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 608L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 609L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 610L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 611L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 612L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 613L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 614L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 615L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 616L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 617L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 618L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 619L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 620L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 621L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 622L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 623L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 624L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 625L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 626L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 627L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 628L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 629L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 630L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 631L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 632L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 633L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 634L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 635L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 636L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 637L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 638L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 639L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 640L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 641L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 642L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 643L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 644L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 645L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 646L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 647L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 648L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 649L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 650L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 651L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 652L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 653L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 654L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 655L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 656L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 657L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 658L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 659L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 660L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 661L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 662L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 663L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 664L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 665L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 666L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 667L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 668L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 669L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 670L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 671L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 672L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 673L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 674L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 675L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 676L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 677L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 678L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 679L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 680L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 681L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 682L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 683L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 684L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 685L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 686L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 687L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 688L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 689L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 690L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 691L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 692L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 693L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 694L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 695L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 696L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 697L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 698L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 699L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 700L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 701L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 702L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 703L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 704L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 705L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 706L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 707L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 708L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 709L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 710L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 711L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 712L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 713L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 714L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 715L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 716L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 717L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 718L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 719L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 720L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 721L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 722L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 723L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 724L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 725L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 726L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 727L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 728L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 729L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 730L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 731L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 732L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 733L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 734L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 735L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 736L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 737L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 738L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 739L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 740L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 741L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 742L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 743L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 744L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 745L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 746L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 747L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 748L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 749L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 750L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 751L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 752L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 753L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 754L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 755L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 756L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 757L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 758L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 759L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 760L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 761L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 762L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 763L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 764L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 765L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 766L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 767L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 768L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 769L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 770L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 771L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 772L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 773L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 774L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 775L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 776L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 777L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 778L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 779L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 780L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 781L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 782L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 783L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 784L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 785L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 786L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 787L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 788L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 789L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 790L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 791L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 792L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 793L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 794L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 795L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 796L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 797L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 798L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 799L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 800L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 801L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 802L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 803L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 804L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 805L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 806L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 807L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 808L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 809L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 810L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 811L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 812L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 813L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 814L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 815L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 816L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 817L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 818L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 819L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 820L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 821L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 822L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 823L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 824L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 825L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 826L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 827L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 828L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 829L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 830L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 831L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 832L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 833L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 834L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 835L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 836L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 837L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 838L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 839L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 840L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 841L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 842L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 843L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 844L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 845L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 846L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 847L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 848L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 849L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 850L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 851L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 852L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 853L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 854L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 855L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 856L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 857L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 858L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 859L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 860L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 861L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 862L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 863L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 864L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 865L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 866L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 867L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 868L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 869L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 870L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 871L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 872L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 873L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 874L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 875L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 876L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 877L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 878L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 879L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 880L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 881L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 882L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 883L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 884L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 885L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 886L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 887L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 888L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 889L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 890L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 891L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 892L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 893L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 894L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 895L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 896L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 897L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 898L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 899L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 900L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 901L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 902L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 903L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 904L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 905L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 906L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 907L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 908L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 909L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 910L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 911L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 912L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 913L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 914L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 915L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 916L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 917L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 918L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 919L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 920L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 921L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 922L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 923L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 924L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 925L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 926L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 927L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 928L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 929L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 930L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 931L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 932L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 933L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 934L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 935L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 936L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 937L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 938L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 939L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 940L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 941L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 942L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 943L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 944L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 945L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 946L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 947L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 948L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 949L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 950L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 951L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 952L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 953L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 954L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 955L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 956L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 957L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 958L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 959L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 960L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 961L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 962L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 963L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 964L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 965L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 966L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 967L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 968L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 969L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 970L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 971L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 972L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 973L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 974L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 975L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 976L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 977L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 978L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 979L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 980L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 981L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 982L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 983L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 984L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 985L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 986L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 987L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 988L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 989L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 990L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 991L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 992L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 993L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 994L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 995L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 996L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 997L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 998L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 999L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1000L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1001L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1002L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1003L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1004L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1005L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1006L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1007L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1008L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1009L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1010L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1011L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1012L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1013L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1014L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1015L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1016L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1017L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1018L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1019L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1020L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1021L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1022L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1023L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1024L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1025L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1026L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1027L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1028L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1029L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1030L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1031L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1032L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1033L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1034L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1035L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1036L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1037L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1038L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1039L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1040L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1041L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1042L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1043L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1044L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1045L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1046L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1047L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1048L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1049L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1050L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1051L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1052L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1053L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1054L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1055L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1056L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1057L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1058L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1059L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1060L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1061L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1062L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1063L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1064L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1065L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1066L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1067L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1068L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1069L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1070L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1071L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1072L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1073L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1074L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1075L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1076L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1077L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1078L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1079L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1080L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1081L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1082L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1083L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1084L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1085L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1086L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1087L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1088L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1089L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1090L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1091L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1092L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1093L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1094L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1095L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1096L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1097L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1098L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1099L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1100L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1101L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1102L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1103L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1104L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1105L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1106L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1107L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1108L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1109L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1110L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1111L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1112L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1113L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1114L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1115L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1116L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1117L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1118L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1119L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1120L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1121L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1122L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1123L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1124L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1125L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1126L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1127L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1128L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1129L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1130L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1131L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1132L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1133L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1134L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1135L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1136L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1137L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1138L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1139L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1140L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1141L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1142L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1143L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1144L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1145L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1146L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1147L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1148L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1149L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1150L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1151L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1152L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1153L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1154L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1155L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1156L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1157L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1158L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1159L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1160L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1161L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1162L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1163L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1164L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1165L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1166L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1167L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1168L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1169L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1170L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1171L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1172L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1173L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1174L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1175L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1176L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1177L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1178L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1179L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1180L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1181L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1182L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1183L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1184L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1185L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1186L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1187L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1188L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1189L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1190L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1191L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1192L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1193L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1194L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1195L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1196L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1197L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1198L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1199L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1200L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1201L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1202L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1203L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1204L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1205L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1206L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1207L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1208L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1209L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1210L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1211L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1212L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1213L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1214L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1215L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1216L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1217L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1218L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1219L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1220L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1221L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1222L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1223L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1224L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1225L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1226L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1227L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1228L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1229L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1230L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1231L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1232L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1233L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1234L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1235L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1236L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1237L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1238L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1239L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1240L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1241L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1242L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1243L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1244L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1245L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1246L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1247L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1248L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1249L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1250L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1251L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1252L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1253L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1254L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1255L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1256L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1257L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1258L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1259L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1260L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1261L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1262L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1263L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1264L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1265L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1266L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1267L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1268L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1269L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1270L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1271L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1272L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1273L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1274L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1275L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1276L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1277L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1278L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1279L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1280L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1281L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1282L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1283L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1284L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1285L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1286L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1287L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1288L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1289L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1290L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1291L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1292L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1293L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1294L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1295L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1296L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1297L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1298L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1299L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1300L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1301L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1302L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1303L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1304L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1305L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1306L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1307L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1308L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1309L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1310L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1311L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1312L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1313L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1314L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1315L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1316L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1317L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1318L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1319L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1320L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1321L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1322L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1323L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1324L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1325L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1326L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1327L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1328L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1329L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1330L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1331L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1332L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1333L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1334L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1335L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1336L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1337L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1338L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1339L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1340L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1341L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1342L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1343L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1344L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1345L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1346L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1347L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1348L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1349L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1350L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1351L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1352L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1353L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1354L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1355L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1356L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1357L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1358L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1359L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1360L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1361L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1362L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1363L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1364L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1365L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1366L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1367L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1368L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1369L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1370L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1371L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1372L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1373L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1374L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1375L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1376L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1377L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1378L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1379L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1380L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1381L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1382L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1383L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1384L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1385L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1386L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1387L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1388L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1389L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1390L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1391L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1392L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1393L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1394L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1395L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1396L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1397L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1398L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1399L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1400L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1401L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1402L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1403L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1404L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1405L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1406L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1407L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1408L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1409L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1410L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1411L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1412L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1413L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1414L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1415L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1416L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1417L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1418L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1419L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1420L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1421L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1422L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1423L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1424L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1425L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1426L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1427L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1428L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1429L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1430L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1431L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1432L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1433L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1434L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1435L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1436L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1437L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1438L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1439L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1440L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1441L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1442L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1443L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1444L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1445L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1446L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1447L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1448L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1449L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1450L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1451L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1452L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1453L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1454L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1455L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1456L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1457L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1458L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1459L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1460L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1461L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1462L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1463L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1464L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1465L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1466L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1467L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1468L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1469L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1470L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1471L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1472L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1473L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1474L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1475L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1476L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1477L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1478L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1479L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1480L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1481L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1482L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1483L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1484L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1485L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1486L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1487L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1488L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1489L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1490L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1491L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1492L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1493L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1494L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1495L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1496L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1497L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1498L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1499L);

            migrationBuilder.DeleteData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1500L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentor-role", "3" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentor-role", "4" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, "6" });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 2L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Needs improvement before publishing", 1 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 4L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Needs improvement before publishing", 1 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 6L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Needs improvement before publishing", 1 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 8L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Needs improvement before publishing", 1 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 10L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Needs improvement before publishing", 1 });

            migrationBuilder.UpdateData(
                table: "AdminReviewCourses",
                keyColumn: "ReviewId",
                keyValue: 12L,
                columns: new[] { "ReviewNotes", "Status" },
                values: new object[] { "Needs improvement before publishing", 1 });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 1L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 0L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 2L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 0L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 3L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 4L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 4L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 4L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 5L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 8L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 6L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 8L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 7L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 12L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 8L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 13L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 9L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 17L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 10L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 17L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 11L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 20L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 12L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 20L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 13L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 24L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 14L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 24L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 15L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 28L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 16L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 28L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 17L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 32L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 18L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 33L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 19L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 37L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 20L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 37L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 21L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 40L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 22L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 40L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 23L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 44L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 24L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 44L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 25L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 48L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 26L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 48L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 27L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 52L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 28L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 53L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 29L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 57L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 30L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 57L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 31L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 60L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 32L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 60L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 33L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 64L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 34L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 64L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 35L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 68L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 36L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 68L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 37L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 72L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 38L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 73L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 39L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 77L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 40L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 77L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 41L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 80L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 42L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 80L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 43L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 84L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 44L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 84L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 45L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 88L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 46L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 88L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 47L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 92L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 48L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 93L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 49L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 97L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 50L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 97L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 51L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 100L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 52L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 100L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 53L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 104L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 54L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 104L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 55L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 108L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 56L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 108L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 57L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 112L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 58L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 113L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 59L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 117L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 60L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 117L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 61L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 120L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 62L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 120L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 63L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 124L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 64L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 124L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 65L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 128L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 66L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 128L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 67L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 132L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 68L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 133L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 69L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 137L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 70L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 137L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 71L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 140L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 72L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 140L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 73L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 144L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 74L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 144L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 75L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 148L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 76L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 148L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 77L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 152L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 78L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 153L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 79L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 157L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 80L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 157L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 81L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 160L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 82L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 160L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 83L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 164L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 84L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 164L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 85L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 168L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 86L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 168L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 87L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 172L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 88L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 173L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 89L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 177L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 90L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 177L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 91L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 180L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 92L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 180L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 93L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 184L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 94L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 184L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 95L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 188L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 96L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 188L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 97L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 192L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 98L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 193L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 99L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 197L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 100L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 197L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 101L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 200L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 102L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 200L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 103L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 204L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 104L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 204L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 105L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 208L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 106L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 208L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 107L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 212L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 108L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 213L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 109L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 217L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 110L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 217L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 111L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 220L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 112L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 220L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 113L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 224L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 114L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 224L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 115L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 228L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 116L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 228L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 117L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 232L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 118L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 233L, "4" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 119L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 237L, "3" });

            migrationBuilder.UpdateData(
                table: "AnswerQuizzes",
                keyColumn: "AnswerQuizId",
                keyValue: 120L,
                columns: new[] { "OptionId", "UserId" },
                values: new object[] { 237L, "4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 33L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 34L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 35L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 36L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 37L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 38L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 39L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 40L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 41L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 42L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 43L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 44L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 45L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 46L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 47L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 48L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 49L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 50L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 51L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 52L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 53L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 54L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 55L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 56L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 57L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 58L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 59L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 60L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 61L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 62L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 63L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 64L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 65L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 66L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 67L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 68L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 69L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 70L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 71L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 72L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 73L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 74L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 75L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 76L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 77L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 78L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 79L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 80L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 81L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 82L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 83L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 84L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 85L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 86L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 87L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 88L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 89L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 90L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 91L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 92L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 93L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 94L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 95L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 96L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 97L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 98L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 99L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 100L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 101L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 102L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 103L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 104L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 105L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 106L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 107L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 108L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 109L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 110L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 111L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 112L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 113L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 114L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 115L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 116L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 117L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 118L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 119L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 120L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 121L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 122L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 123L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 124L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 125L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 126L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 127L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 128L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 129L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 130L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 131L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 132L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 133L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 134L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 135L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 136L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 137L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 138L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 139L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 140L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 141L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 142L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 143L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 144L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 145L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 146L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 147L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 148L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 149L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 150L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 151L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 152L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 153L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 154L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 155L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 156L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 157L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 158L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 159L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 160L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 161L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 162L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 163L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 164L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 165L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 166L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 167L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 168L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 169L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 170L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 171L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 172L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 173L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 174L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 175L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 176L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 177L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 178L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 179L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 180L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 181L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 182L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 183L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 184L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 185L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 186L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 187L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 188L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 189L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 190L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 191L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 192L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 193L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 194L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 195L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 196L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 197L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 198L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 199L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 200L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 201L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 202L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 203L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 204L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 205L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 206L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 207L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 208L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 209L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 210L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 211L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 212L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 213L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 214L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 215L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 216L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 217L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 218L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 219L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 220L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 221L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 222L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 223L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 224L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 225L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 226L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 227L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 228L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 229L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 230L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 231L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 232L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 233L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 234L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 235L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 236L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 237L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 238L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 239L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 240L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 241L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 242L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 243L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 244L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 245L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 246L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 247L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 248L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 249L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 250L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 251L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 252L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 253L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 254L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 255L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 256L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 257L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 258L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 259L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 260L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 261L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 262L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 263L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 264L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 265L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 266L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 267L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 268L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 269L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 270L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 271L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 272L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 273L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 274L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 275L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 276L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 277L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 278L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 279L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 280L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 281L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 282L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 283L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 284L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 285L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 286L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 287L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 288L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 289L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 290L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 291L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 292L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 293L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 294L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 295L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 296L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 297L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 298L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 299L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 300L,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UserId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AdminReviewerId", "ReviewedAt", "UserId" },
                values: new object[] { null, null, "4" });

            migrationBuilder.UpdateData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AdminReviewerId", "UserId" },
                values: new object[] { "2", "5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1L,
                column: "Content",
                value: "Chào mừng bạn đến với hệ thống học trực tuyến!");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2L,
                column: "Content",
                value: "Cảm ơn admin, mình rất hào hứng!");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3L,
                column: "Content",
                value: "Bạn có muốn tham gia nhóm học chung không?");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4L,
                column: "Content",
                value: "Ok, mình rất quan tâm.");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5L,
                column: "Content",
                value: "Chúng tôi đã nhận được đơn ứng tuyển mentor của bạn.");

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                columns: new[] { "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2857), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                columns: new[] { "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2866), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2869), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2870), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2871), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2873), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2874), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2875), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2876), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2877), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2878), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2879), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2880), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2881), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2882), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2883), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2883), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2885), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2886), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2887), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2887), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2888), "4" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2889), "3" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "EndTime", "StartTime", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 7, 17, 39, 35, 526, DateTimeKind.Local).AddTicks(2890), "4" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 1L,
                column: "UserId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 2L,
                column: "UserId",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 5L,
                column: "UserId",
                value: "7");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 6L,
                column: "UserId",
                value: "8");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 7L,
                column: "UserId",
                value: "9");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 8L,
                column: "UserId",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 9L,
                column: "UserId",
                value: "11");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 10L,
                column: "UserId",
                value: "12");

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 1L,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 19.99m, "3" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 2L,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 29.99m, "3" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 3L,
                columns: new[] { "Amount", "Description", "Status", "UserId" },
                values: new object[] { 24.99m, "Pending payment for course 3", 0, "3" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 4L,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 34.99m, "3" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 5L,
                columns: new[] { "Amount", "Description", "Status", "UserId" },
                values: new object[] { 39.99m, "Failed transaction for course 5", 2, "3" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 6L,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 44.99m, "3" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "mentee-role", "3" },
                    { "mentee-role", "4" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "89f39e78-2793-4c3b-80af-85085bd7d7be", "AQAAAAIAAYagAAAAENvCAPmboz6tj+ENgiXHuK5lPPzrxbTLzKvstQTqAnctJwQBd6eSpjl3QkXOIllcUg==", "137e38da-946a-4330-8287-886fb5a417ac", new DateTime(2025, 11, 7, 17, 39, 35, 527, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8563094e-3fbd-4daa-94a2-d7a2212f6b28", "AQAAAAIAAYagAAAAEGsdgQlBMXGy+Ifze50nM+2A/QE292HDOKkl3C0F4QtydF5jNoLaKc330SE28zUSQg==", "51174c67-3ba8-44c9-af10-21d6c454b850", new DateTime(2025, 11, 7, 17, 39, 35, 899, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0820a519-b62c-40c6-aac1-12d743896bbf", "AQAAAAIAAYagAAAAEGSRECXOEpQnXW8bKJsnqWKMnDOB1sBow/+M/NVzuRELMhdpBEcPySXK+8jm9L+H/w==", "7a2c27e9-227d-4acf-8cf3-12c795924c3f", new DateTime(2025, 11, 7, 17, 39, 35, 943, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "95dec817-26b5-4bf6-ab78-108f9a8cb61d", "AQAAAAIAAYagAAAAEJYQGMPHOPXUnPdccY7oBGr/2WuFfoEQcfSFDCGbHOErAYlmXmx7myQRCxwOXeyd9w==", "d129af2a-bfa3-4763-95a1-b7aa20a38ef2", new DateTime(2025, 11, 7, 17, 39, 35, 983, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2667ff94-fd9e-46ce-a647-5a3b43162443", "AQAAAAIAAYagAAAAECEBXLzcKCOXMHJ3bhAjvMF7XsqNLjdg5dsqzAmlUC8kA1B3JOKnGuim2DD5hO3edw==", "dc61c592-eb93-4d1a-aecd-32d2970e028f", new DateTime(2025, 11, 7, 17, 39, 36, 24, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7753dfdd-1956-4d1b-8e2f-030e537162dc", "AQAAAAIAAYagAAAAEFk3viNckjwn+8WaADldV5I9rTAaN26Ti+5e1+/qIFA18gZIsD7LzOKLpJB6phGUvg==", "4a5cb701-19aa-4a80-aaba-a8d9846d52b6", new DateTime(2025, 11, 7, 17, 39, 36, 65, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "576ab71a-88d9-4474-b12e-2c10ef2a4168", "AQAAAAIAAYagAAAAELvRs/sK7yTEVATUy1zGihtOfXAMvWK5lu1HG+Usmql0k+mypycMkmspKFzMP0bEuw==", "59c9ed0d-957b-4f89-b4e6-14baa8e3cb15", new DateTime(2025, 11, 7, 17, 39, 36, 106, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8ff4e301-db3f-49af-a000-2f92744d60c8", "AQAAAAIAAYagAAAAEP7c2uA4PAtp1pIL8qtOvCVbAsdZmnDZSMHkBRAcW8UtOca5rwkSs9th3yoEmjx1pQ==", "4270b853-0b07-406b-bcfe-1116c567fbb6", new DateTime(2025, 11, 7, 17, 39, 36, 144, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b73c2369-193c-4691-b36c-cb8ed407561d", "AQAAAAIAAYagAAAAEBx0XGs62Fq+3QBRsd+H/VuUcYBNOjW3TQbsmaSwvsrvC6TJFVh4cWtcCBgm6O2N9Q==", "d6d81454-d267-4905-b511-be6767f500e3", new DateTime(2025, 11, 7, 17, 39, 36, 184, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1c0d6d43-a1f2-4997-99d2-773928c0dae1", "AQAAAAIAAYagAAAAECKs3oqMfyCabwVsCclwcu7U5CdNFtwRssKmy4+NllNYvRka1Z8+0zJhNG6zt6p9+g==", "9f625057-067f-4092-afe2-196b5b2bbfb4", new DateTime(2025, 11, 7, 17, 39, 36, 224, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5e919b3e-9eb9-47b0-9e73-247b810b9b9e", "AQAAAAIAAYagAAAAEALM2PoqqK5UBQNR2lMk4UdPlavMFV6rwlfWxOzQOySKXVQa2WHKdQajaQ/DITO0ZA==", "b8c69e0b-cc87-4b9a-829a-aad239ab5f02", new DateTime(2025, 11, 7, 17, 39, 36, 264, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "009aeb7a-fcad-4fdc-b7b7-650df5331da2", "mentor@demo.com", "Demo Mentor", "MENTOR@DEMO.COM", "MENTOR@DEMO.COM", "AQAAAAIAAYagAAAAEKRxl/nXcE1rY+xKlfFMa1nUo8tLz83PFfni3MPxr8FDgmCFjWZt29d37aUw1BDy2g==", "44c03337-7976-454b-9460-dd35e2fc3059", new DateTime(2025, 11, 7, 17, 39, 35, 568, DateTimeKind.Local).AddTicks(5960), "mentor@demo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "81f2772b-2ac7-43f7-93e9-ccaaee24a30b", "AQAAAAIAAYagAAAAED1FY2ZwuAGljce1KuyQqH5Ygff3dP2c5YbuD8Sbqj7xVviV8Yf/cIt3d55UzIk24w==", "8aa938d0-8481-43f7-9d36-52e933a579cf", new DateTime(2025, 11, 7, 17, 39, 36, 304, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "69cd8238-7e2f-4695-b575-be1c5ff3ef15", "AQAAAAIAAYagAAAAEAvy1GCz6WFYBp4kMWFxJ6V7dFRyR8pyE5OewJ2ONm0CJJA64ss7K8NyYFtj/Qtbzw==", "44ba7b86-cd0d-4277-881e-61fb1e253876", new DateTime(2025, 11, 7, 17, 39, 36, 344, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0585826a-0d20-425a-8048-f75d41fcb943", "AQAAAAIAAYagAAAAEOEIM1r2iemUyHvoSV3NbaLjxGlZRKKLBIpyM4wdY0yo+xhEuu0xS3b/TmiwYxc+0w==", "63dce24e-164f-43b0-a456-eeaf37e1aaef", new DateTime(2025, 11, 7, 17, 39, 36, 383, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1effbafb-0e5c-4dba-857e-7735827d6494", "AQAAAAIAAYagAAAAENcMBM7Mi3vPIMGKfsUvhQb2JkI13utr+8nHIP1LRfRfZBgcXGt5/moMBoaU+VJLog==", "1074cbfb-2900-457e-9960-654e0ad8c226", new DateTime(2025, 11, 7, 17, 39, 36, 424, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d4982348-9fca-443a-86a7-60e1e83583de", "AQAAAAIAAYagAAAAEPRsTawmLOe/KIfSrMW3fwyTTgW0+KyrGfc/W8OrK+BHTtR+WpTUHNSYkRPjvna1wA==", "8fb1b98e-e479-4c51-89e6-073d2e7edea0", new DateTime(2025, 11, 7, 17, 39, 36, 465, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "319fdf17-0a9c-4972-8505-fc383f78eae9", "AQAAAAIAAYagAAAAEJ473RQdcXRRl669iL8oFsh/BLy0N+toXwfZakbZlOP2BFWTQsbDYnWGgJd7Bqm+wg==", "5f78532f-5db7-44e4-a069-3e545d339141", new DateTime(2025, 11, 7, 17, 39, 36, 503, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ab7b7403-13db-4428-9900-ab30a9cfca04", "AQAAAAIAAYagAAAAEMbf+7D9yuQrcm3wQLnF8txmuO3OgK45u11zOzzF3rGOpNtnkXpjmfn8EOeBBkGEng==", "8db1c09f-f3bb-4d45-a042-7de00fc48dcc", new DateTime(2025, 11, 7, 17, 39, 36, 543, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d33a8b82-784d-4d71-b093-f4e46f0e2e75", "AQAAAAIAAYagAAAAEET85wcMLB+5qBsBBOlMx9IaFX+rU/Iq9Xl0XIG63TugSFZsVjfZTDlAbaUWoANdoQ==", "cf8032bc-085c-483a-aea7-ac559a0e45c3", new DateTime(2025, 11, 7, 17, 39, 36, 583, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "30066d44-cdcc-4e0a-acf9-d7900384fdc6", "AQAAAAIAAYagAAAAEKMwGiYF12qhX83KAQbhrag9IPcLini4XW5hX8f6puksNUb8oBM47yMIbbcLc47b3Q==", "e5162cbc-04a8-477a-95ae-53f4637f7a41", new DateTime(2025, 11, 7, 17, 39, 36, 624, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "529945d2-7767-42f9-9364-06fa35aebfa6", "AQAAAAIAAYagAAAAEOqv9hrRRMzeIy0yOOM9JeHvGWDY8tCmxVKr64rZSxdlv+c2TiGDyJ15Yri5nOTnRA==", "20b881ae-191c-46a7-a2b9-912027043704", new DateTime(2025, 11, 7, 17, 39, 36, 664, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/mentee1/200/200", "6d662337-07f4-4f45-a080-67935290d65b", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1998, 3, 3), "mentee1@example.com", "Mentee One", "MENTEE1@EXAMPLE.COM", "MENTEE1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAqSagSRu2LWeilBtqbtoKQOws8lzf/0Q2/ryrrJZ3ooY775bb4k+C4WoB4xS/VBBg==", "0900000003", "0597cc88-c80e-47ce-b718-bc41ed872b85", new DateTime(2025, 11, 7, 17, 39, 35, 611, DateTimeKind.Local).AddTicks(921), "mentee1@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "38f488c7-276d-4e79-bbee-9dc33d0b9f67", "AQAAAAIAAYagAAAAEIeXpmEkhF7JsOymUV6obg+kFUdMA5ASmAPh65YB/Bw8Fj5SaVtBXQX9eNcF/OlBiA==", "3f6f503f-0fa5-49da-865a-6ff5a0a11a3f", new DateTime(2025, 11, 7, 17, 39, 36, 704, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f0dfcfc7-394a-4271-b068-945ad8355534", "AQAAAAIAAYagAAAAEFWdEyE3+otpL0pvklX5eRTXoBRyMcvRHetMOzr9dMKQKaHo3nF3V+NBb5Iy6CjnLg==", "fba927f0-1b78-4f79-9c8b-7faa75e016c3", new DateTime(2025, 11, 7, 17, 39, 36, 745, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2c9d4f9c-c3dc-405c-8ef2-8ae0ee1f6b78", "AQAAAAIAAYagAAAAEHdZ7AQbf3hftBgxHmcCb/ZOCEuEGY/n4LFwHIWYf6BGcS1SqG5HsygtvV4HK5u8+w==", "165cf165-c7e8-4a22-8cd2-22a6c48b1f6b", new DateTime(2025, 11, 7, 17, 39, 36, 785, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "53804fef-42fc-4e06-a238-9b5c62e765a3", "AQAAAAIAAYagAAAAEBzMNGTaMaFWDOcn65gh5Zq3LNCr0/q3WWPGSa8gTxywm6/au3Ihdup97X+uz6E6SA==", "aa3e5a8d-cfeb-437c-b947-71009bee3d36", new DateTime(2025, 11, 7, 17, 39, 36, 825, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "04740246-fcb2-42e3-9cc3-844473472171", "AQAAAAIAAYagAAAAEMgAgvpXhPnwNgZrvR9OmOZKDlErifo2YXictTOXUqwhKDdaZz3z8t/aTjJNqW71DQ==", "e75eaf55-6f4d-4477-89e8-a8c5b7592be7", new DateTime(2025, 11, 7, 17, 39, 36, 865, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "86b37740-e70d-47a5-9de0-b5efb1759879", "AQAAAAIAAYagAAAAEAMBBdfEMzM7wend1qLfgke6QiVF55s6XFDcsqkgLPS/EoLA9h4DeyEuoI2Lb+VoTw==", "4d4d8485-65a3-4fc0-a630-4b25544bddae", new DateTime(2025, 11, 7, 17, 39, 36, 905, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "90abf699-45c6-4311-8390-fc73cfd648d9", "AQAAAAIAAYagAAAAEC0kF9lVb0/Zs6J/5DWB+KGBBLocFY63DiRqY+J2Z6pTxraf2fdPO+dgY27M7wEBMQ==", "05ab8bab-c146-4c1b-93a8-1db1452e9676", new DateTime(2025, 11, 7, 17, 39, 36, 945, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1c391b19-3a5c-47c2-a466-cf6f3af4a0d2", "AQAAAAIAAYagAAAAEIkM9xDNQ7fenHQF/SLwVt5bkLBheL2CY+c1t6H609PqJnrpoGYgvnsHVann/GRG6Q==", "74ed17b6-6ed6-4834-a2ef-0b229500e1d8", new DateTime(2025, 11, 7, 17, 39, 36, 984, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e1bfa1fc-f4e7-41df-ac08-db73c66fc84d", "AQAAAAIAAYagAAAAEDip7q7E04J4nSf7pImvkUyajbrPK38/iicGA1QyrjIzTkA4tpJgJ5rap39OGvHhRw==", "543f814e-1975-4c4e-bd54-b968ac9ddf94", new DateTime(2025, 11, 7, 17, 39, 37, 24, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "abffd3e9-bcc2-485a-baa5-f8c9c685284d", "AQAAAAIAAYagAAAAEPko4QMoAPF9sifreXz611pUYTGmZnHKvVp2fUPCn68wTuFL8UZu3PfhzzNwu/gLVA==", "02f869f0-6f90-42a2-a195-0920eb076760", new DateTime(2025, 11, 7, 17, 39, 37, 65, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/mentee2/200/200", "4cb98c83-f29a-4efa-bfa4-071de9384034", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1997, 4, 4), "mentee2@example.com", "Mentee Two", false, "MENTEE2@EXAMPLE.COM", "MENTEE2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKoeWf6NWgiv6dqt1Aa0grhrdkqIA92vNu3fRJ22nKcM5GlhBpvvlf5HuPAowV8wtA==", "0900000004", "ff4e1eeb-4b1c-469e-9b0d-7f9039676adf", new DateTime(2025, 11, 7, 17, 39, 35, 650, DateTimeKind.Local).AddTicks(9586), "mentee2@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "52bb2c25-c61f-4299-b622-4310d86136d3", "AQAAAAIAAYagAAAAEFqxhh05skN5oLz4KGJRNwa6FLEihG5IR4NHCh1e9R6ptDtFOrAU4aSvzEm9p4Y9mQ==", "e4df14db-362c-40c3-9460-631a997fcc24", new DateTime(2025, 11, 7, 17, 39, 37, 105, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8727dd59-302a-47c4-8ac5-47fb1254b33a", "AQAAAAIAAYagAAAAEPYaf17Gadd+yhGwbgR7hJwoAbd3OP/bDMxZaVsMhd090h+XZ294ixPYsa83GUHJ2g==", "8a907065-5726-43bf-8f16-f3b89ce0c1b7", new DateTime(2025, 11, 7, 17, 39, 37, 146, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1cb2b097-259b-4861-a3d5-d85dc906a4ee", "AQAAAAIAAYagAAAAEK7kv+omW28is8U0o/xRd5ZjUqWvLQP7UHhkdW/zHPi84faH8QpGb8+adETziTrk1A==", "c645c759-864e-4607-8a2b-31e505cfa987", new DateTime(2025, 11, 7, 17, 39, 37, 186, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c4ec1c7b-f07e-4c39-a6ab-b64235f58d6c", "AQAAAAIAAYagAAAAEFm3Z0r8I2GbxZafCDfIWZwgYbfCeO37eAmuOuGAZLHKfnms0xEb1tRoXAs6KvWPrA==", "839574ea-56f1-4edc-99c7-ba93c4514ac8", new DateTime(2025, 11, 7, 17, 39, 37, 226, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d0ebb484-6c86-4e00-bf09-b8e4601b1102", "AQAAAAIAAYagAAAAEK5gDsPV2w3j0lqjetw8cBxIf2SbG9qsz/9Sio7zEg3FLoqrFyU4xmBUzVQcgjYLbg==", "fdcfe76c-2fc5-4507-8f9d-cd7619c01863", new DateTime(2025, 11, 7, 17, 39, 37, 264, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5f3d8d03-1795-40a2-80e2-44bcd148938e", "AQAAAAIAAYagAAAAEK9N/13+foJQYAJarKWx14x/RW0F3DsvSHEg3cggYaMlP+Uyz//0cQw1EmuStsqG2A==", "5103b7a4-b11e-4a26-a0a3-553c4a4aedb4", new DateTime(2025, 11, 7, 17, 39, 37, 305, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "933ed93e-7b5f-43db-8e7d-7cecd9e41df1", "AQAAAAIAAYagAAAAEDBMHs0anonSOJ9/Vjeaanumg+WzoDN0Wr+Oc6g7ATfRYgM1wVrykc3o3wW1VEKOsQ==", "13d40444-a884-4553-b0c2-5b5d55119b6b", new DateTime(2025, 11, 7, 17, 39, 37, 345, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "60021959-d269-463b-9d9e-ecddb00bd94f", "AQAAAAIAAYagAAAAEPhlOEM1gSmRPz6cV3/n8epXeKgOTv23rdwuVzMw1icSiPacr/XJvhkxyTDXOmx1GA==", "02c01179-0635-4bd4-8329-d118eaa415f6", new DateTime(2025, 11, 7, 17, 39, 37, 387, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d5ac91e3-a6b5-4d24-abb1-dd31e1da4cbc", "AQAAAAIAAYagAAAAEJWynZsiFkOCgwIwDxpmATb+099qRJoYE5POs3Wm30lMP4OlBoTNju07hf/eVzp+AA==", "0403d993-87e2-465c-a39b-7a6cb70dd3a2", new DateTime(2025, 11, 7, 17, 39, 37, 428, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "71e3b13c-a112-4fab-8d76-82cf2e7cb735", "AQAAAAIAAYagAAAAEDKG1Vf1a/QljUkarvRwEWVb7JWcUGnZt3hawbkxom22E5KpTls58sq0Zm8v7LuI8Q==", "ea226a56-cd5c-4a79-bfd3-54980ce17377", new DateTime(2025, 11, 7, 17, 39, 37, 469, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/mentee3/200/200", "a5e417ef-82cc-4439-9c7d-76dd6e8c8f19", new DateOnly(1996, 5, 5), "mentee3@example.com", "Mentee Three", "MENTEE3@EXAMPLE.COM", "MENTEE3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIVpviPJFTceZJGfUcBTrKnLdRa0C/p1os8vcz4dEIWu+lCWRvHgLaK/VUHNGQmYyw==", "0900000005", "8f9b379d-045c-4f0c-adcb-f5310f6e0728", new DateTime(2025, 11, 7, 17, 39, 35, 693, DateTimeKind.Local).AddTicks(4735), "mentee3@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5bd9a8af-882c-4efd-9434-99065c5ae86b", "AQAAAAIAAYagAAAAEHp8tvbxp9g6pAtHeQj82BjHrJsSXxsvMheLcvSjJ/rKAqEc3/4jiZ/VpcRK4AAqFA==", "288c4bc8-da0c-4bba-8d41-2294bbd35976", new DateTime(2025, 11, 7, 17, 39, 37, 509, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/6/200/200", "a7959124-4f98-45f7-94fd-5ee74bd4db5a", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1994, 1, 1), "user6@example.com", "User 6", true, "USER6@EXAMPLE.COM", "USER6@EXAMPLE.COM", "AQAAAAIAAYagAAAAECFMzG5mcMyhrjikY+sYa7HOxvKRZ52xo5Sn35Hnsz36FMnssnYahb7t8TkNi8RixA==", "0900000006", "eed53217-5acc-4adf-b1ea-100a9d41055f", new DateTime(2025, 11, 7, 17, 39, 35, 736, DateTimeKind.Local).AddTicks(3740), "user6@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/7/200/200", "1d9a1ace-1d53-4aa6-a10e-5ecbcc93cf42", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1993, 1, 1), "user7@example.com", "User 7", false, "USER7@EXAMPLE.COM", "USER7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMyKwwlcXdInQpxkfIEXVExlBqsRWYFkyLeAYanNHRebMHjvokDXPQIP5w2fRSzOrQ==", "0900000007", "b59f0703-73d1-4405-821a-9b1d5969fafe", new DateTime(2025, 11, 7, 17, 39, 35, 778, DateTimeKind.Local).AddTicks(4996), "user7@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f35bfc08-60b3-44c3-8d6f-4a61bd230bcc", "AQAAAAIAAYagAAAAEDSOq8oimayF6trkr9JhLJlOkXi3ySQJY8yR+935Ulz5zwlAjMZDh7nTBukYSyBf5w==", "d99760a9-f086-4243-bc6a-22d81b4ae554", new DateTime(2025, 11, 7, 17, 39, 35, 817, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c5cc753a-31e9-4cf6-9521-2d373567ed35", "AQAAAAIAAYagAAAAEAw+Pfyvt9tvhzZpIjfX0pFGI9G0VOiBVIEap1CJjuIHWRLsGAb1rVGNtyO5lhfDYA==", "e2bb7414-ace9-4d90-8753-70ff7b139f14", new DateTime(2025, 11, 7, 17, 39, 35, 857, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "6" },
                column: "CreatedAt",
                value: new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "WishLists",
                columns: new[] { "CourseId", "UserId", "CreatedAt" },
                values: new object[,]
                {
                    { 1L, "3", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "4", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "5", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "5", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "3", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
