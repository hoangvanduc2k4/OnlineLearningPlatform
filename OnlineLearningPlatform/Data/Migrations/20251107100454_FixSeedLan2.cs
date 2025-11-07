using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedLan2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseImageUrls",
                columns: new[] { "Id", "CourseId", "Url" },
                values: new object[,]
                {
                    { 37L, 13L, "https://picsum.photos/seed/course13_img1/600/400" },
                    { 38L, 13L, "https://picsum.photos/seed/course13_img2/600/400" },
                    { 39L, 13L, "https://picsum.photos/seed/course13_img3/600/400" },
                    { 40L, 14L, "https://picsum.photos/seed/course14_img1/600/400" },
                    { 41L, 14L, "https://picsum.photos/seed/course14_img2/600/400" },
                    { 42L, 14L, "https://picsum.photos/seed/course14_img3/600/400" },
                    { 43L, 15L, "https://picsum.photos/seed/course15_img1/600/400" },
                    { 44L, 15L, "https://picsum.photos/seed/course15_img2/600/400" },
                    { 45L, 15L, "https://picsum.photos/seed/course15_img3/600/400" },
                    { 46L, 16L, "https://picsum.photos/seed/course16_img1/600/400" },
                    { 47L, 16L, "https://picsum.photos/seed/course16_img2/600/400" },
                    { 48L, 16L, "https://picsum.photos/seed/course16_img3/600/400" },
                    { 49L, 17L, "https://picsum.photos/seed/course17_img1/600/400" },
                    { 50L, 17L, "https://picsum.photos/seed/course17_img2/600/400" },
                    { 51L, 17L, "https://picsum.photos/seed/course17_img3/600/400" },
                    { 52L, 18L, "https://picsum.photos/seed/course18_img1/600/400" },
                    { 53L, 18L, "https://picsum.photos/seed/course18_img2/600/400" },
                    { 54L, 18L, "https://picsum.photos/seed/course18_img3/600/400" },
                    { 55L, 19L, "https://picsum.photos/seed/course19_img1/600/400" },
                    { 56L, 19L, "https://picsum.photos/seed/course19_img2/600/400" },
                    { 57L, 19L, "https://picsum.photos/seed/course19_img3/600/400" },
                    { 58L, 20L, "https://picsum.photos/seed/course20_img1/600/400" },
                    { 59L, 20L, "https://picsum.photos/seed/course20_img2/600/400" },
                    { 60L, 20L, "https://picsum.photos/seed/course20_img3/600/400" },
                    { 61L, 21L, "https://picsum.photos/seed/course21_img1/600/400" },
                    { 62L, 21L, "https://picsum.photos/seed/course21_img2/600/400" },
                    { 63L, 21L, "https://picsum.photos/seed/course21_img3/600/400" },
                    { 64L, 22L, "https://picsum.photos/seed/course22_img1/600/400" },
                    { 65L, 22L, "https://picsum.photos/seed/course22_img2/600/400" },
                    { 66L, 22L, "https://picsum.photos/seed/course22_img3/600/400" },
                    { 67L, 23L, "https://picsum.photos/seed/course23_img1/600/400" },
                    { 68L, 23L, "https://picsum.photos/seed/course23_img2/600/400" },
                    { 69L, 23L, "https://picsum.photos/seed/course23_img3/600/400" },
                    { 70L, 24L, "https://picsum.photos/seed/course24_img1/600/400" },
                    { 71L, 24L, "https://picsum.photos/seed/course24_img2/600/400" },
                    { 72L, 24L, "https://picsum.photos/seed/course24_img3/600/400" },
                    { 73L, 25L, "https://picsum.photos/seed/course25_img1/600/400" },
                    { 74L, 25L, "https://picsum.photos/seed/course25_img2/600/400" },
                    { 75L, 25L, "https://picsum.photos/seed/course25_img3/600/400" },
                    { 76L, 26L, "https://picsum.photos/seed/course26_img1/600/400" },
                    { 77L, 26L, "https://picsum.photos/seed/course26_img2/600/400" },
                    { 78L, 26L, "https://picsum.photos/seed/course26_img3/600/400" },
                    { 79L, 27L, "https://picsum.photos/seed/course27_img1/600/400" },
                    { 80L, 27L, "https://picsum.photos/seed/course27_img2/600/400" },
                    { 81L, 27L, "https://picsum.photos/seed/course27_img3/600/400" },
                    { 82L, 28L, "https://picsum.photos/seed/course28_img1/600/400" },
                    { 83L, 28L, "https://picsum.photos/seed/course28_img2/600/400" },
                    { 84L, 28L, "https://picsum.photos/seed/course28_img3/600/400" },
                    { 85L, 29L, "https://picsum.photos/seed/course29_img1/600/400" },
                    { 86L, 29L, "https://picsum.photos/seed/course29_img2/600/400" },
                    { 87L, 29L, "https://picsum.photos/seed/course29_img3/600/400" },
                    { 88L, 30L, "https://picsum.photos/seed/course30_img1/600/400" },
                    { 89L, 30L, "https://picsum.photos/seed/course30_img2/600/400" },
                    { 90L, 30L, "https://picsum.photos/seed/course30_img3/600/400" },
                    { 91L, 31L, "https://picsum.photos/seed/course31_img1/600/400" },
                    { 92L, 31L, "https://picsum.photos/seed/course31_img2/600/400" },
                    { 93L, 31L, "https://picsum.photos/seed/course31_img3/600/400" },
                    { 94L, 32L, "https://picsum.photos/seed/course32_img1/600/400" },
                    { 95L, 32L, "https://picsum.photos/seed/course32_img2/600/400" },
                    { 96L, 32L, "https://picsum.photos/seed/course32_img3/600/400" },
                    { 97L, 33L, "https://picsum.photos/seed/course33_img1/600/400" },
                    { 98L, 33L, "https://picsum.photos/seed/course33_img2/600/400" },
                    { 99L, 33L, "https://picsum.photos/seed/course33_img3/600/400" },
                    { 100L, 34L, "https://picsum.photos/seed/course34_img1/600/400" },
                    { 101L, 34L, "https://picsum.photos/seed/course34_img2/600/400" },
                    { 102L, 34L, "https://picsum.photos/seed/course34_img3/600/400" },
                    { 103L, 35L, "https://picsum.photos/seed/course35_img1/600/400" },
                    { 104L, 35L, "https://picsum.photos/seed/course35_img2/600/400" },
                    { 105L, 35L, "https://picsum.photos/seed/course35_img3/600/400" },
                    { 106L, 36L, "https://picsum.photos/seed/course36_img1/600/400" },
                    { 107L, 36L, "https://picsum.photos/seed/course36_img2/600/400" },
                    { 108L, 36L, "https://picsum.photos/seed/course36_img3/600/400" },
                    { 109L, 37L, "https://picsum.photos/seed/course37_img1/600/400" },
                    { 110L, 37L, "https://picsum.photos/seed/course37_img2/600/400" },
                    { 111L, 37L, "https://picsum.photos/seed/course37_img3/600/400" },
                    { 112L, 38L, "https://picsum.photos/seed/course38_img1/600/400" },
                    { 113L, 38L, "https://picsum.photos/seed/course38_img2/600/400" },
                    { 114L, 38L, "https://picsum.photos/seed/course38_img3/600/400" },
                    { 115L, 39L, "https://picsum.photos/seed/course39_img1/600/400" },
                    { 116L, 39L, "https://picsum.photos/seed/course39_img2/600/400" },
                    { 117L, 39L, "https://picsum.photos/seed/course39_img3/600/400" },
                    { 118L, 40L, "https://picsum.photos/seed/course40_img1/600/400" },
                    { 119L, 40L, "https://picsum.photos/seed/course40_img2/600/400" },
                    { 120L, 40L, "https://picsum.photos/seed/course40_img3/600/400" },
                    { 121L, 41L, "https://picsum.photos/seed/course41_img1/600/400" },
                    { 122L, 41L, "https://picsum.photos/seed/course41_img2/600/400" },
                    { 123L, 41L, "https://picsum.photos/seed/course41_img3/600/400" },
                    { 124L, 42L, "https://picsum.photos/seed/course42_img1/600/400" },
                    { 125L, 42L, "https://picsum.photos/seed/course42_img2/600/400" },
                    { 126L, 42L, "https://picsum.photos/seed/course42_img3/600/400" },
                    { 127L, 43L, "https://picsum.photos/seed/course43_img1/600/400" },
                    { 128L, 43L, "https://picsum.photos/seed/course43_img2/600/400" },
                    { 129L, 43L, "https://picsum.photos/seed/course43_img3/600/400" },
                    { 130L, 44L, "https://picsum.photos/seed/course44_img1/600/400" },
                    { 131L, 44L, "https://picsum.photos/seed/course44_img2/600/400" },
                    { 132L, 44L, "https://picsum.photos/seed/course44_img3/600/400" },
                    { 133L, 45L, "https://picsum.photos/seed/course45_img1/600/400" },
                    { 134L, 45L, "https://picsum.photos/seed/course45_img2/600/400" },
                    { 135L, 45L, "https://picsum.photos/seed/course45_img3/600/400" },
                    { 136L, 46L, "https://picsum.photos/seed/course46_img1/600/400" },
                    { 137L, 46L, "https://picsum.photos/seed/course46_img2/600/400" },
                    { 138L, 46L, "https://picsum.photos/seed/course46_img3/600/400" },
                    { 139L, 47L, "https://picsum.photos/seed/course47_img1/600/400" },
                    { 140L, 47L, "https://picsum.photos/seed/course47_img2/600/400" },
                    { 141L, 47L, "https://picsum.photos/seed/course47_img3/600/400" },
                    { 142L, 48L, "https://picsum.photos/seed/course48_img1/600/400" },
                    { 143L, 48L, "https://picsum.photos/seed/course48_img2/600/400" },
                    { 144L, 48L, "https://picsum.photos/seed/course48_img3/600/400" },
                    { 145L, 49L, "https://picsum.photos/seed/course49_img1/600/400" },
                    { 146L, 49L, "https://picsum.photos/seed/course49_img2/600/400" },
                    { 147L, 49L, "https://picsum.photos/seed/course49_img3/600/400" },
                    { 148L, 50L, "https://picsum.photos/seed/course50_img1/600/400" },
                    { 149L, 50L, "https://picsum.photos/seed/course50_img2/600/400" },
                    { 150L, 50L, "https://picsum.photos/seed/course50_img3/600/400" }
                });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 1L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "This is the detailed sample answer for question 1 regarding payment. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Sample Question 1: What is the policy for payment?" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 2L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "This is the detailed sample answer for question 2 regarding account access. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Sample Question 2: What is the policy for account access?" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 3L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "This is the detailed sample answer for question 3 regarding course content. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Sample Question 3: What is the policy for course content?" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 4L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "This is the detailed sample answer for question 4 regarding certificates. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Sample Question 4: What is the policy for certificates?" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 5L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "This is the detailed sample answer for question 5 regarding refunds. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Sample Question 5: What is the policy for refunds?" });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FaqId", "Answer", "CommonStatus", "CreatedAt", "Question", "UpdatedAt" },
                values: new object[,]
                {
                    { 6L, "This is the detailed sample answer for question 6 regarding support. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 6: What is the policy for support?", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, "This is the detailed sample answer for question 7 regarding mobile app. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 7: What is the policy for mobile app?", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, "This is the detailed sample answer for question 8 regarding instructor. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 8: What is the policy for instructor?", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, "This is the detailed sample answer for question 9 regarding payment. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 9: What is the policy for payment?", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, "This is the detailed sample answer for question 10 regarding account access. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 10: What is the policy for account access?", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, "This is the detailed sample answer for question 11 regarding course content. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 11: What is the policy for course content?", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12L, "This is the detailed sample answer for question 12 regarding certificates. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 12: What is the policy for certificates?", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13L, "This is the detailed sample answer for question 13 regarding refunds. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 13: What is the policy for refunds?", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14L, "This is the detailed sample answer for question 14 regarding support. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 14: What is the policy for support?", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15L, "This is the detailed sample answer for question 15 regarding mobile app. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 15: What is the policy for mobile app?", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16L, "This is the detailed sample answer for question 16 regarding instructor. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 16: What is the policy for instructor?", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17L, "This is the detailed sample answer for question 17 regarding payment. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 17: What is the policy for payment?", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18L, "This is the detailed sample answer for question 18 regarding account access. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 18: What is the policy for account access?", new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19L, "This is the detailed sample answer for question 19 regarding course content. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 19: What is the policy for course content?", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20L, "This is the detailed sample answer for question 20 regarding certificates. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 20: What is the policy for certificates?", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21L, "This is the detailed sample answer for question 21 regarding refunds. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 21: What is the policy for refunds?", new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22L, "This is the detailed sample answer for question 22 regarding support. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 22: What is the policy for support?", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23L, "This is the detailed sample answer for question 23 regarding mobile app. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 23: What is the policy for mobile app?", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24L, "This is the detailed sample answer for question 24 regarding instructor. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 24: What is the policy for instructor?", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25L, "This is the detailed sample answer for question 25 regarding payment. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 25: What is the policy for payment?", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26L, "This is the detailed sample answer for question 26 regarding account access. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 26: What is the policy for account access?", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27L, "This is the detailed sample answer for question 27 regarding course content. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 27: What is the policy for course content?", new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28L, "This is the detailed sample answer for question 28 regarding certificates. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 28: What is the policy for certificates?", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29L, "This is the detailed sample answer for question 29 regarding refunds. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 29: What is the policy for refunds?", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30L, "This is the detailed sample answer for question 30 regarding support. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 30: What is the policy for support?", new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31L, "This is the detailed sample answer for question 31 regarding mobile app. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 31: What is the policy for mobile app?", new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32L, "This is the detailed sample answer for question 32 regarding instructor. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 32: What is the policy for instructor?", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33L, "This is the detailed sample answer for question 33 regarding payment. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 33: What is the policy for payment?", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34L, "This is the detailed sample answer for question 34 regarding account access. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 34: What is the policy for account access?", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35L, "This is the detailed sample answer for question 35 regarding course content. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 35: What is the policy for course content?", new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36L, "This is the detailed sample answer for question 36 regarding certificates. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 36: What is the policy for certificates?", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37L, "This is the detailed sample answer for question 37 regarding refunds. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 37: What is the policy for refunds?", new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38L, "This is the detailed sample answer for question 38 regarding support. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 38: What is the policy for support?", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39L, "This is the detailed sample answer for question 39 regarding mobile app. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 39: What is the policy for mobile app?", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40L, "This is the detailed sample answer for question 40 regarding instructor. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 40: What is the policy for instructor?", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41L, "This is the detailed sample answer for question 41 regarding payment. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 41: What is the policy for payment?", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42L, "This is the detailed sample answer for question 42 regarding account access. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 42: What is the policy for account access?", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43L, "This is the detailed sample answer for question 43 regarding course content. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 43: What is the policy for course content?", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44L, "This is the detailed sample answer for question 44 regarding certificates. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 44: What is the policy for certificates?", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45L, "This is the detailed sample answer for question 45 regarding refunds. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 45: What is the policy for refunds?", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46L, "This is the detailed sample answer for question 46 regarding support. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 46: What is the policy for support?", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47L, "This is the detailed sample answer for question 47 regarding mobile app. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 47: What is the policy for mobile app?", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48L, "This is the detailed sample answer for question 48 regarding instructor. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 48: What is the policy for instructor?", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49L, "This is the detailed sample answer for question 49 regarding payment. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 49: What is the policy for payment?", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50L, "This is the detailed sample answer for question 50 regarding account access. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 0, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Question 50: What is the policy for account access?", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4b636209-8113-45ed-b0cb-e55fa32a3db4", "AQAAAAIAAYagAAAAEGGxDhj35T7007Bt4A8SjvntvDtmnAglvUty0qIRtZQBzLsKWfSJDumltqkQ2qtfig==", "9e2377ed-07ef-4a5f-a420-b4c0496964d8", new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b3594d53-ac35-4ffd-a124-eef92aa5a1f2", "AQAAAAIAAYagAAAAEOShF3Okl1ejoHPqNlJDh1PAuOro1s+mplrTQOkZXsz6Luf/8yiwvxqC9o2rO4kaTQ==", "8e9bfdc0-5581-4d0c-9766-28bf9953a915", new DateTime(2025, 11, 7, 17, 4, 51, 536, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bd4b6315-9be4-4d96-b07d-bbaf3d67cb45", "AQAAAAIAAYagAAAAEHYUj/xrJ/aWZzrV8lH1Yk2zwEapnWjsKgoBazsA1gefE1hGi9FLdjwA/kFd5IyZ0Q==", "a9ecbff6-80d1-40b7-97d4-af873d03ed8f", new DateTime(2025, 11, 7, 17, 4, 51, 576, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3ad387f6-0be3-4b11-b0a1-4a482791e73e", "AQAAAAIAAYagAAAAEEgxtZKeU/m+joZDh5CZgm7a5Kvz24r/26y6B8YbC4HkBgR1y9rZpVaadboIMtz54A==", "e4898f3a-0d8d-4b99-9d27-04754eb92449", new DateTime(2025, 11, 7, 17, 4, 51, 617, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a619c6c8-50dc-4b0f-bb70-93b538d84f51", "AQAAAAIAAYagAAAAENJ49rVivwFwdmfcn2bwUTXn3eyqQIAX/dkGBH8Ssc6/0wSLt7SxKTNEUNEq0AnGpg==", "0a6929ae-0a61-4e62-a405-205d521e4238", new DateTime(2025, 11, 7, 17, 4, 51, 659, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e14b9285-2d49-4f65-bca0-8e2a206369c3", "AQAAAAIAAYagAAAAEJDvvwYzmCn2sPwrQKfVKWcybN80dfHsZsI+rpSkaTTz4n45qbzYL4RyPrAqTDyo7g==", "17359f79-bc15-424c-8be5-61714bacb72e", new DateTime(2025, 11, 7, 17, 4, 51, 700, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a9a3500a-9ea2-4391-bec6-c409e963b00d", "AQAAAAIAAYagAAAAEA1rYpmIid0RIpZb9AnMo5uLsuHP8d+K7Zkt+D1CuZVNmLAaeeX2OwD122vYjEOVzg==", "6c3120c7-6f83-4bae-8d3e-b95c223142ba", new DateTime(2025, 11, 7, 17, 4, 51, 741, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fcced67d-9792-4303-999a-83ada1e7bc8c", "AQAAAAIAAYagAAAAENdVK9ns7RZ9NmlGY8LJacfpa3AGdUoBiTsqYyxxafUX8eZiYRI/MbDvb+z3v39YKA==", "079a63d7-0536-4b7d-8b16-133e6656ca12", new DateTime(2025, 11, 7, 17, 4, 51, 781, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9ea1f14c-baef-437c-9b6f-506136ffb60a", "AQAAAAIAAYagAAAAEL6jrvPRZ8s3brOW6Fw0P5LRW7mGHvITPR7gtzqKJGiG/HjsstyeqXRidM56KyJTcQ==", "c0b9d800-a187-4d90-aa6a-da8123441382", new DateTime(2025, 11, 7, 17, 4, 51, 822, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7d5e76c5-ae54-4be0-88f3-188ac47e4492", "AQAAAAIAAYagAAAAEBikMpFaBs+a+Ctk2+1q66g9XyxqLm4TX04hODXz0WituVLjAfNFf01tFmYdEfOiFA==", "f3773a2f-17aa-44d2-acc3-1715628bdc07", new DateTime(2025, 11, 7, 17, 4, 51, 861, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "814ad285-5258-4dd9-b35f-7f3780dce765", "AQAAAAIAAYagAAAAEMNtQNgBUgANZZzzX7hJXVt0+FUfAnRSuKCIRpVoSdHc9DS0BmMHUSSUonug0COJCg==", "91eee0d2-fb64-46de-9c39-c35514a39a98", new DateTime(2025, 11, 7, 17, 4, 51, 900, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0a72eb2b-bd0c-44d4-8698-9e07d93866d3", "AQAAAAIAAYagAAAAEGnIIVRdbdpX7Qz5j12itUHWBeXYyUUEub/o/hrUqp7uvoEdBsEmT7xZt8T87/poow==", "154ed329-d9f8-4e41-be81-8e90d7a01013", new DateTime(2025, 11, 7, 17, 4, 51, 209, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "042233cb-2b2e-4086-89f0-5f4411f50b3a", "AQAAAAIAAYagAAAAEHG66l73wq5VLbRsnjnfuDFyvBwDpNqzi1SQIBtmeq7TFbK9fKgFq8+JVpJ8dkLtQg==", "0b9cb08b-97fa-4932-81a6-ae71344dc1c9", new DateTime(2025, 11, 7, 17, 4, 51, 939, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dfe83569-80da-4db1-84f6-e763d7d76ddf", "AQAAAAIAAYagAAAAEGyqzpbX7OFvShRlCij5maJHGnR3QIuNSIxvkEXXXu3RtyQim5juhQSB07AY3DDRhg==", "d7dc7d93-b3e8-4871-9cb0-d32ea0e67aa6", new DateTime(2025, 11, 7, 17, 4, 51, 979, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ec9edeb4-a995-4606-939f-8ea7b7476d81", "AQAAAAIAAYagAAAAEHEuNka0FTAfD6it4UQUwus7LEx6gkIFSCdhyqrg6abD9wutnHUoambF8XcAJDvunA==", "cd4f246e-72ad-47ea-9546-e5024b178b63", new DateTime(2025, 11, 7, 17, 4, 52, 21, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a83db2d9-d42d-4dbe-b817-3e92ae078b9e", "AQAAAAIAAYagAAAAEEtdowAFH/F1Hlkd4a0o+k4KFKzOeJu1WofZyRT8mD/5xP5B6qsq3D/F6Xt8yBgP9g==", "4cfca961-9521-4e00-9ece-0be40915f0d3", new DateTime(2025, 11, 7, 17, 4, 52, 61, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3dfa8b44-c48c-4c51-b222-4ed30b64f932", "AQAAAAIAAYagAAAAEJbI07CkjbYlhrZRTg/OHutrR+D8Y4KZOjaydDD+KxMeRrIjbUrclBV3F2p0n9gs9A==", "73f22c3b-be55-4e1a-9a71-774dd750d276", new DateTime(2025, 11, 7, 17, 4, 52, 103, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ae405221-1a49-4f7f-8176-c9528622ecb5", "AQAAAAIAAYagAAAAEPth9n2SgPlkFwpTeZbV2HUGSjBeQ5Qf57hTEPekpez2j1ONcm+2dXwYs7uNcX3y0g==", "abe38ed0-10df-4e65-a925-2c20ca740c73", new DateTime(2025, 11, 7, 17, 4, 52, 145, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e1491b68-2485-491c-871c-4efc965fd9d8", "AQAAAAIAAYagAAAAEL4TkfzG8DUHasQJ6R+3gzJpaGVHUR/sbZTTcec0kfeciPwCpEAEeSt8g2qu9edRLA==", "1e78ff3e-5c7c-45e1-ac77-b14c5ac676d3", new DateTime(2025, 11, 7, 17, 4, 52, 190, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ee7990a9-25c6-4fc8-8ca7-edc0aeb47deb", "AQAAAAIAAYagAAAAEE2Q3cEYRWcXVIi5esEDtLl5+wZglB7R3JwZKlPpb3O+9MVJDZWAW181Bk7xwGi+Zg==", "09c2a397-5d59-4a64-bdf5-cc6941850899", new DateTime(2025, 11, 7, 17, 4, 52, 232, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d6335f6f-9aa3-4380-be4e-56e9b1a144bb", "AQAAAAIAAYagAAAAEFJYzscDVYJu+fHVuLcMgyYryvFsgYloATm4LGUGy3xQviVvePM+SGlJs//k2OsOlg==", "14be59fd-2df3-4cac-9f64-85fd4340ca29", new DateTime(2025, 11, 7, 17, 4, 52, 272, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6b377ea6-e600-4076-8664-5fccadf080b1", "AQAAAAIAAYagAAAAEMxhi6DTgCITTAmBfi/J72Hhv+Bi/Y9fIJV0wXgBr+7VoYQ15DSzNHN8wCL+q29SgA==", "b1c58378-d0a5-45e9-b4ef-3a9ebec452c6", new DateTime(2025, 11, 7, 17, 4, 52, 310, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "07a7adac-32b7-417d-8bb0-b96bf071ab73", "AQAAAAIAAYagAAAAEEeN97yMg5s6vdGw+4ScS41vLtAJ9TK9sH6EE4sItIIuoHSdC04d9dP3upSZwoIwyg==", "ca75643e-4395-435a-a34f-afe93275a7a1", new DateTime(2025, 11, 7, 17, 4, 51, 248, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5dfb11ff-3e05-4364-8b9e-65c6c16e1bf2", "AQAAAAIAAYagAAAAEC4nIUNIPAvSMMp9ZDraJqoQJPsviPn6ZgM6X+8HxSZ25lE3mFUOYJKOmJc8rmUdmA==", "327b6db8-c8f1-4d7b-892b-157615c52bc5", new DateTime(2025, 11, 7, 17, 4, 52, 350, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "976b2f21-8326-400a-b9da-292bffe40f20", "AQAAAAIAAYagAAAAEFOMT7xwRlZru0xwnp7eGEtl9xHqRqsIA1hvRPjNMgEKWn9qS8RTmn9Hdu/1yOnk5A==", "3ddcd77f-ea3e-43fa-9632-81dd892ca264", new DateTime(2025, 11, 7, 17, 4, 52, 390, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1a19cf43-b209-4f68-8482-bfc8b8666e0d", "AQAAAAIAAYagAAAAEIipZeL0v9qTJb5M0rq38/WnOg5fwmIb7Eq8tnAD6G00E89WxFeIugc4aWiuO0gUcA==", "f7196a2d-964e-428b-b515-eea98fe7e5b4", new DateTime(2025, 11, 7, 17, 4, 52, 430, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c78a3335-a796-4dd4-9814-12026a42ec8e", "AQAAAAIAAYagAAAAEETIajillgrpxamYK7A69cFFcxlh3fO1hrISetHqnGPIyebQLr8JKu2+g1WWvDYWCA==", "a9501c2f-1609-4553-a244-99c99b56de0b", new DateTime(2025, 11, 7, 17, 4, 52, 471, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "db1071ab-773a-43a1-a57f-9e7b2063b40e", "AQAAAAIAAYagAAAAEDfyYljEIZWtmohtx+jbD9JWOROQLd5APZtaPLZUXc4/IvAxPoi9L0z76LbDG9XOkg==", "b3068fbe-d617-4637-be68-d455d07b32a2", new DateTime(2025, 11, 7, 17, 4, 52, 511, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "62b41839-97e7-4ee5-ac11-d3594322454c", "AQAAAAIAAYagAAAAEMxEFwGduJoRXYYwjitx6hzJJpM56XY71F9H7pyBvCfs7pV+FY+NtC/4rfbzSA+Few==", "2dc2e068-4854-4143-954c-0d01e8104d9d", new DateTime(2025, 11, 7, 17, 4, 52, 552, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dac95709-7088-4a19-bea2-38e5a3dcf60e", "AQAAAAIAAYagAAAAEP/VuxoybF2s0C968lBwlNh2y+zbg+wALYDx17fEgzRNItND3MYSPJzDz6cCY10ztg==", "b61a912a-b7f8-4414-97cb-35a5767311c5", new DateTime(2025, 11, 7, 17, 4, 52, 592, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0c08db48-b332-40fd-b460-dd6e7005cb0d", "AQAAAAIAAYagAAAAEH3mV/ko5dD2deZEuUli/73kz1Cqb+Uz+fgKEJCSi6LbeLUVQ80TqY3cY8DXypXQGw==", "e8abd741-1c78-4656-b45c-87d4b4de8799", new DateTime(2025, 11, 7, 17, 4, 52, 631, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4d15b3fd-f9ab-4fde-8de8-13c23d5345e8", "AQAAAAIAAYagAAAAEJCfA1wbIB95qxcuWB4ud0WRjSxVs6A49xCFwsylWGx290tGpBzZ/4/F5DYyUwlvfw==", "f726e308-e104-4038-9e69-f26ca0a1d863", new DateTime(2025, 11, 7, 17, 4, 52, 671, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "edfd6dce-ffd5-4055-924c-c460381e9089", "AQAAAAIAAYagAAAAEPYdWg+NY+PJuj1QgPRCVmIKs/xGKi60Y8wzrWkz8p2+3UTxtsHbGY64Bj7sWrKK7Q==", "b88f7750-ce81-4240-b677-2582fad0326e", new DateTime(2025, 11, 7, 17, 4, 52, 712, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9c77a5d1-10af-441e-a58e-57e695c997a2", "AQAAAAIAAYagAAAAEJVMV3/SXaGa41V9MTxXZUY3PC+/J6YRqJ+QpsX3EeLIHyMTiSupHC1dsH2niiWHBQ==", "212fee24-1190-488e-8dbc-e18b419e33a9", new DateTime(2025, 11, 7, 17, 4, 51, 291, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5f020bae-cec1-4cbb-8753-4f8463f1af10", "AQAAAAIAAYagAAAAEIurJ5MDvU+b7ZCfxDaIE7zV1E5cyg+XlJcS0wYCZ9rGUCUEfId+wAR8VaEKfNtDWg==", "be3f3664-383f-449f-9ebb-dc279121ef93", new DateTime(2025, 11, 7, 17, 4, 52, 752, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f6c99d94-20c2-4d3b-b123-c35cbd00cce1", "AQAAAAIAAYagAAAAELPPMjDIcFMW5mh304Q7sM0Qy7T9sfzG0X0krzgaUHRYmhvpjkSnK8lIDYU3ElEwVw==", "238a8d26-cdff-4b0f-94f1-16d5a2918e5a", new DateTime(2025, 11, 7, 17, 4, 52, 794, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a0c1bc10-4609-4cec-be1d-93cf260041e5", "AQAAAAIAAYagAAAAEGWBTmu2ZRg5LOGgkQhXZMk14S/OMhNiBKkIECBykIPrppzmyq0WjrSy/rGovQfYow==", "9e7e0c1b-0744-4b41-94f4-53c6d4bb96c8", new DateTime(2025, 11, 7, 17, 4, 52, 836, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5bf7f698-beec-42df-b11f-559413d71fde", "AQAAAAIAAYagAAAAEJhr4FWNwTAlYmQ2hJgPlSUhHvHTHgzRfgGwBWdgUvaLEH7Q1atXKL/5ElBfYsGOYw==", "2f7bf9cb-a6b9-4072-aef2-9b4d09ae3d19", new DateTime(2025, 11, 7, 17, 4, 52, 877, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cd18d218-574d-49e4-98c7-86a90cbf3efd", "AQAAAAIAAYagAAAAEKApuYZ89DRTUY1S139/gGYLBI531jAy7DCIYeofkfUy3VqalMRM8MG7JyRxMS1DoA==", "2a63554d-cdfd-4be3-bcb7-39d97ca29bd6", new DateTime(2025, 11, 7, 17, 4, 52, 918, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "81d30027-05da-4e4e-be51-78a2cea08cfd", "AQAAAAIAAYagAAAAEPIUDbd19z9D+Cx3SAdXFHcgV0kgzUELk1nsv5X1ur3TD61zmjI3K9GwvfYdehgpxg==", "4ee30a0e-50d3-4abd-9cf5-a50e81fa749e", new DateTime(2025, 11, 7, 17, 4, 52, 957, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0cd026f1-35aa-498c-a6c8-c6cab0b59cc0", "AQAAAAIAAYagAAAAEFzrCdiaPcAHZOUJ9uwmUfcf6d/eBCAXUlYkRhbzqAdhVdzQ0Ui+RrZELCNt4yi6Ug==", "ce9a0bfc-aa98-4702-8f74-65abd4f3fce7", new DateTime(2025, 11, 7, 17, 4, 52, 996, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "eee09199-72f7-436d-910f-3dcd4e33f52c", "AQAAAAIAAYagAAAAEEIiWPex3BBel9ItL0x3oQ6nOza4sa/1SZw+2Zl8YuU+C2ezjHXRoM9YOc6ENgFKIA==", "b499c407-fa74-4cea-bc64-5ff390020386", new DateTime(2025, 11, 7, 17, 4, 53, 36, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "085586d5-d61a-40fa-86dc-a25a76b8ff08", "AQAAAAIAAYagAAAAEDdYFBP9IrxWyPGyRC/NtJ6VNay0cVHvEEYuzFOWU/XnrJPYAFo+b4KInVE1IXbAoA==", "635c7103-9682-4e23-b400-792512fc1870", new DateTime(2025, 11, 7, 17, 4, 53, 77, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "450facdc-f737-4fcf-8845-a914f91a50ad", "AQAAAAIAAYagAAAAECvBsz5JVjFLRYFpnxfHgMnAnWf5QVqdttJSVjAbsx2iMAnJZ/zAlVWb8zQlLEP38A==", "6ad80b9f-28ea-4321-92c3-58a2817db6ed", new DateTime(2025, 11, 7, 17, 4, 53, 117, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "39377b96-d2fc-445b-a910-bc1156d4771f", "AQAAAAIAAYagAAAAEPKVBBTiT3Z6Ao7MC2wpBb7Tw/uuJLd7QJ5b2Dky9KlWw6+6wQF9oleTJ6tsVwKE1w==", "ef1f92ea-8f12-4033-b0b9-0363980b3e82", new DateTime(2025, 11, 7, 17, 4, 51, 333, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9d689200-2c90-4eea-bbee-60aef716ce1e", "AQAAAAIAAYagAAAAEPQ634CwHhvVin9BC2GXgWCmeaEVQVnmiPnJhU2b0fpDlfAUhdKE0X8w34LIs3jl0A==", "de8df70d-3c5d-492f-a5c1-8722dd41862d", new DateTime(2025, 11, 7, 17, 4, 53, 157, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dbb94100-4a97-424e-82e4-e8d1c1a66cb2", "AQAAAAIAAYagAAAAELcNmkCFFbdCiQDqZODEm0CX5P3wTrgvY9U6Se5TqYkmNXRtX/o4wl+0Ts263WfwPw==", "2522a8fe-e2dd-4336-a3e5-00d721587c40", new DateTime(2025, 11, 7, 17, 4, 51, 373, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "14784472-6678-4876-9af1-f45751228064", "AQAAAAIAAYagAAAAEIp3hqb5xTGMqzX7ZnZawaAizRBE8E1IwTWFcGcCWd1BBZpC0J2nDlBIJCfc+cfErA==", "80dd5299-827a-4eee-b384-0330a4956a67", new DateTime(2025, 11, 7, 17, 4, 51, 414, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e3be31c0-2bf7-4aea-8a69-a83945da44ad", "AQAAAAIAAYagAAAAEGdIWvWdq23QGq3Sf74xotuOffTcmD3tgZ05j4tr+Cz9ZUwOkTw0+SylXiW0c24DRQ==", "c6d44e94-49d2-4e13-9803-a9654456708e", new DateTime(2025, 11, 7, 17, 4, 51, 454, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e3785afa-27e9-43d7-9a26-a70b5816688f", "AQAAAAIAAYagAAAAEKb1zTkr8C+S0myp6rnGylBrshV6UWJ3SEWW35l/Mk68BHJ4OBDm9xmk9Khd68vnjg==", "ad6c7612-5761-4060-8f74-83ca90d0b2be", new DateTime(2025, 11, 7, 17, 4, 51, 495, DateTimeKind.Local).AddTicks(5061) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 50L);

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 1L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "Bạn có thể nhấn vào nút Đăng ký trên trang chủ và điền đầy đủ thông tin yêu cầu.", "Làm thế nào để đăng ký tài khoản?" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 2L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "Một số khóa học được cung cấp miễn phí, bạn có thể tìm trong danh mục 'Khóa học miễn phí'.", "Tôi có thể học các khóa học miễn phí không?" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 3L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "Chúng tôi hỗ trợ thanh toán qua thẻ ngân hàng, ví điện tử và PayPal.", "Phương thức thanh toán nào được hỗ trợ?" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 4L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "Bạn có thể nộp đơn ứng tuyển Mentor trong mục 'Trở thành giảng viên'.", "Làm thế nào để trở thành giảng viên?" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqId",
                keyValue: 5L,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "Có, nền tảng hỗ trợ cả trên web và ứng dụng di động.", "Tôi có thể học trên điện thoại không?" });

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
    }
}
