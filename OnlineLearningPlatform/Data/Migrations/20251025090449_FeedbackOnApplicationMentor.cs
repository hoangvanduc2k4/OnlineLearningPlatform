using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class FeedbackOnApplicationMentor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Feedback",
                table: "MentorApplications",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Feedback",
                value: null);

            migrationBuilder.UpdateData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Feedback",
                value: null);

            migrationBuilder.UpdateData(
                table: "MentorApplications",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Feedback",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Feedback",
                table: "MentorApplications");

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 19, 20, 33, 3, 148, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e48c1631-c3d5-48c4-8500-251202e4f7e2", "AQAAAAIAAYagAAAAEA/9d2TRTQQUzM+cTUXZVVMQna7FIAczG18FZLNnLUiNf/Ku6+Y19aCnozSLTWJypQ==", "419f9196-91fb-4c9e-88a3-8217577511ed", new DateTime(2025, 10, 19, 20, 33, 3, 149, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bb4904a1-0e55-41c5-85fb-bb53116be218", "AQAAAAIAAYagAAAAEAFo3t8TBoFifDLxS61nQFUo/JQoLqRj6P0hicl1xyC+9EPnydPrD9HYTrIjeLpeNQ==", "936af638-895d-410a-86cc-55fd0e8008c3", new DateTime(2025, 10, 19, 20, 33, 3, 544, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7108f365-7137-4229-8240-6ca90acb483d", "AQAAAAIAAYagAAAAEJ0/oOQvbObLgDEGOd/AQc+ULicgtj971tL05SBUAdZ44yCAH+JrDuRm/pwXSU+zfg==", "f063bc4d-5896-4a65-89f8-33848c09beb8", new DateTime(2025, 10, 19, 20, 33, 3, 588, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "13889055-2b66-4858-8e55-21761a5e678b", "AQAAAAIAAYagAAAAEMQCVF6WOwMPBdBUSbCmFS034wSFPDBUOeC69RtGgABSv8Rx0vFBWAP5rA9m2P/YrQ==", "541bb551-e6f3-4257-95a8-fb57cad377d0", new DateTime(2025, 10, 19, 20, 33, 3, 632, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c7e6ce66-e951-4884-8c7d-a256d7baf65c", "AQAAAAIAAYagAAAAEMpGjaV9194rntPe0lb+3B9yamp9XJcMHlXpHGiYSyJKAUFiz3z0UJsGXBoupzUSRQ==", "dd355bff-915a-48ff-b6ed-12218b19302a", new DateTime(2025, 10, 19, 20, 33, 3, 676, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "84942bfa-034a-491a-8f6a-37e23a745947", "AQAAAAIAAYagAAAAEEbtDyGUYV4+hyUti9GqmPJoBdALmFXhdM+ysXp7GhINBIrbgyfg+D+T2Q8CUMDcUg==", "87bffe2d-1aca-4956-8669-38e8801387da", new DateTime(2025, 10, 19, 20, 33, 3, 719, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "afcb8d70-53aa-4ea2-9fe3-a1b2a0b10b6d", "AQAAAAIAAYagAAAAEARHhglflbKMZPF9vfCFrAy2Yv8GQVk3Qa+Y8UrTGBMVOgnR30gTSPVZCbRG9pW95w==", "2394689a-7ac3-4664-ba14-18e4e64e9a35", new DateTime(2025, 10, 19, 20, 33, 3, 762, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f3315fdf-f4d6-4b42-be94-fa7085b20f28", "AQAAAAIAAYagAAAAEH+rMU09mVVvIUiBOG6GVaN5NA7X3sV1ldR+ahb8qkWrSP9aC20Xc2gPWE8W4AKmFA==", "2967f9dd-ae16-4a64-9c29-8d0aa64b3119", new DateTime(2025, 10, 19, 20, 33, 3, 806, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0743a317-7a9d-45e6-8501-5921c74747d1", "AQAAAAIAAYagAAAAEB7Gcg04ooHrrxADJc9TvTBkbXjfQyTWLPv+clvWxIIVDtWJ5JMaq+qVRBVYvtn9hg==", "5590e341-fc1a-4d6a-9efd-7544fe8ff1e2", new DateTime(2025, 10, 19, 20, 33, 3, 849, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "48ab34f8-020d-47ac-bac2-972ddb0adc59", "AQAAAAIAAYagAAAAEHomAKVkBCauqqrb8KeUq0iJV80zWNBIm8yBNo5LDNBn9lR8ljpxvXBB5vXYF3WTcQ==", "7d8742d4-d15c-4dd9-af82-1e45c7cc72eb", new DateTime(2025, 10, 19, 20, 33, 3, 892, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c22035b8-cf02-4c14-8f7f-720ef4e47424", "AQAAAAIAAYagAAAAEHNbDZOL2roUCFGNSAZC+Se7m7hkBM+W1+9dpcgaJ1kGmVVToVDsZRw0LtJfScC+bA==", "c3df82f4-b631-4413-ba2e-8ff6368b5429", new DateTime(2025, 10, 19, 20, 33, 3, 936, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "763aacac-9728-423b-b61f-a21c69c4463e", "AQAAAAIAAYagAAAAEDhQ69AepBqd1pUYW68syOEMNto3yvUTP7uzGPTQJFTLR0L9+uoY6LRPRmL188Dj6w==", "18089b5d-c5cf-40d5-a631-a5bff04868e4", new DateTime(2025, 10, 19, 20, 33, 3, 193, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1aeb1858-4eb5-42a1-9746-1ed3e774d04d", "AQAAAAIAAYagAAAAEPvGRfqYLMQBAqzGRM6zyRPN4u+j6zjz6Wsly8ZxmXMv2vNW2Zoq5pLjK60XFy9tVA==", "4ddb9bde-14a6-405a-a33e-8cafab9edf35", new DateTime(2025, 10, 19, 20, 33, 3, 979, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fa246ed0-34a1-4e75-9daa-f3cca02cfb0d", "AQAAAAIAAYagAAAAEFtoc59jM4VM2+XwEz9CHjbSQvNs+OV5M4wAsBmgOvIHpvPBwD0k1zgbPYZN7wkTDQ==", "c856d01c-0476-401e-b81a-ceed213f2410", new DateTime(2025, 10, 19, 20, 33, 4, 22, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "148ef604-7b46-409b-b083-d3cb1c62023f", "AQAAAAIAAYagAAAAEHYzOO2vcYpKEsUdCVYfsFpBmOg/FqbSNBaWTHkxcPW2IiRWt3MIe6OiFutz/ZAPAQ==", "1478157b-240f-4299-9104-ce6416c6957a", new DateTime(2025, 10, 19, 20, 33, 4, 66, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "00ccb468-e768-4450-b5d5-dd31d5885c8f", "AQAAAAIAAYagAAAAENbXDgkaw2gvOj2LmfbAQRomtQKZB+bt2U3SQkRbdHB+TBT224Eb9pos1r7PW8Wliw==", "a9c54205-4839-485a-9917-0352d8be7a1a", new DateTime(2025, 10, 19, 20, 33, 4, 110, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dcedf3eb-37f6-404c-94e6-42d6f70c4438", "AQAAAAIAAYagAAAAEJZMsmrvSkItDEUV6MeLPol1OcT17gc7gpr7GIKlpVz0yqbrsJu2kGqulpcOgPyjnQ==", "f82b6c71-bb03-490d-a4d5-597eb0000272", new DateTime(2025, 10, 19, 20, 33, 4, 153, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4b423048-2450-4b55-91f9-193b932fea81", "AQAAAAIAAYagAAAAENqw4fy+8BqFuMX528MTSoIWzfex5WTRo16yqJB1UOYavc5K0wm/D5u8HdZTJmJjdQ==", "0b412a1c-5ed5-4789-9491-dd2176dcbe32", new DateTime(2025, 10, 19, 20, 33, 4, 197, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5f220745-6def-4060-8cca-bcedf9dee970", "AQAAAAIAAYagAAAAEPmgsHOnYFHgme/2newObb5i28pUmRwR6hmHVZn/TB11fLILHR1AqwGgih5by5F7pQ==", "bc9f126c-ec54-48cc-87b3-4eac2864494a", new DateTime(2025, 10, 19, 20, 33, 4, 241, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6e1128bc-0d19-47f6-8212-1eec26cce13f", "AQAAAAIAAYagAAAAEAYgxDHrjNPOQHqJxyOvvss2ZVsoB03gdjqdCSX6GdsKPuffzDLddnDl8MVHmKuGRg==", "e1c28373-4802-41af-896f-dbed63dffcbe", new DateTime(2025, 10, 19, 20, 33, 4, 286, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "488454d5-ccb8-4f1c-b3c2-297f914cf733", "AQAAAAIAAYagAAAAELZC24vhn1w5LyLIloXn6tc9YggVFYOeJqCSLDnkPh0KnzTxpFBybg1yC+z0b3V3pw==", "60cd9f53-a7b8-4d8b-a79e-a630628ecf16", new DateTime(2025, 10, 19, 20, 33, 4, 329, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ed32ad98-4244-4345-b8db-4456f70153d8", "AQAAAAIAAYagAAAAEIxLWq2Hc/TXZ62xoUA9o8iI33Y/SDsjNiTwRAX8H6Ujc0dFykgLVYDyJpv2pb9RfQ==", "e4ce5603-2ea3-47d1-a401-1964ff578302", new DateTime(2025, 10, 19, 20, 33, 4, 374, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b36ef962-44c5-44ef-9f4b-e20bf37d6833", "AQAAAAIAAYagAAAAEL/Si+TpIeSThkuc2CmYMYKhuxTbloG2p3njW+f6DK62Oiqhy5/YsiZK9XQ8TBxXfA==", "cced3840-5744-4415-9f11-8ed275db2c73", new DateTime(2025, 10, 19, 20, 33, 3, 238, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4615851f-23a1-4740-858d-a7690ab960e8", "AQAAAAIAAYagAAAAEHsrQjtxvZWokkoQB0NQHBYU6bEWhCv4crfLtkxmMvHK3DPcrLPZEneKaYgCliRC9A==", "b78a658c-44fd-4b3c-aaf6-4d75b75bcf56", new DateTime(2025, 10, 19, 20, 33, 4, 419, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9600e83a-8d02-4b3c-86e5-0379a20e2144", "AQAAAAIAAYagAAAAEDK/bLz9ONkV6P8pViKNtokHMoaI4ItsDNunCGKP6p6FHR2pBAZ+/MVaAFIh3WgQZA==", "b6b87062-f41b-49be-a8b9-f16666e8a55a", new DateTime(2025, 10, 19, 20, 33, 4, 463, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5233f2bd-a4c2-4e5f-a1e2-cb8f7a9f1074", "AQAAAAIAAYagAAAAEJ54NY+bOVqIp5n3KeZZR1nC1CBtFUMZLuu0wZZrz/hcw1Zf+z4Cv5wU29NwBDbRFg==", "fd4e09ab-d3f4-4e21-a5da-cbf136f6cc4a", new DateTime(2025, 10, 19, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1da064a9-4976-4c3e-bd9a-9858d4ab493d", "AQAAAAIAAYagAAAAELIlaLHfThtwYpG40ZmXWMipxOSo0Pq0KdKTs7/LOHk4qcV9tDkNaAXr++LaTD3doA==", "4c21f4e3-ffd0-46d5-8087-9f2863f7a7eb", new DateTime(2025, 10, 19, 20, 33, 4, 552, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4c4ee4ae-bae7-4779-8e00-f91b17b5872c", "AQAAAAIAAYagAAAAEBNx7u6xOs1TYnna4AGLwJ7EPB+1LKoGnOQLDEQCKLyDHtXHKh+Jtif8a+yvTENIPQ==", "7966b780-3474-4cd9-9eeb-4d223f5cff08", new DateTime(2025, 10, 19, 20, 33, 4, 597, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "66dfdfe5-a596-4d33-b110-135e1b054c87", "AQAAAAIAAYagAAAAEGslHpyYtc0NZjlWTeL577p5P0fFPC/igHMJyPMcciyvgbcAlfeAuHRb3tHceGX02Q==", "9538ada9-f033-4f41-94ee-1be4a2cc4357", new DateTime(2025, 10, 19, 20, 33, 4, 640, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3066465c-e92e-4b4f-a583-ff1ff0b06a12", "AQAAAAIAAYagAAAAEBSN2urVBSo+V3neFjt0SAP6e5GSl4BkQ3566gRLDoh+vzQUMxq49a9H2pBOQ9m2UA==", "486cea70-f03c-4de6-b785-d4e2bd3a5de7", new DateTime(2025, 10, 19, 20, 33, 4, 683, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "11e316b7-09ff-4b19-919f-aa5f7d76603b", "AQAAAAIAAYagAAAAEBqyVl01BWNYMcO5UZR3sKcXbveGbnvh6ZdEdOme3XoAl6BUifrJtBD6rTEMVDZmbQ==", "ff8ac3a7-8bf4-4506-9293-fa0387639e74", new DateTime(2025, 10, 19, 20, 33, 4, 727, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d99c6956-7a3c-4a6e-a454-23a0fc2d23bc", "AQAAAAIAAYagAAAAEMlD5ISLwLNEK9lfyFftB4nj1YqNqwh9LdLmUDvWTp2Cx37r94s+YyjobdgInvyboQ==", "c9d97708-5871-4683-95c3-1dd007d76c2c", new DateTime(2025, 10, 19, 20, 33, 4, 771, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a0088447-1577-40ec-ab30-44e88a1aa8ad", "AQAAAAIAAYagAAAAEE/XSsjgcmYT/9DOwNw1DyJkUddzK3maliqe/j4x49g1cMTqBTTw7Z4Tz8LrPKJSNA==", "469702d1-1125-4689-b6c5-5baac9dcd1e3", new DateTime(2025, 10, 19, 20, 33, 4, 815, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5448f33d-ef51-40a9-86f4-c1f6c10c3a03", "AQAAAAIAAYagAAAAEOFdG6bHnzl7vCv0qeTuyoXSlp8dPDONY4Vo7zvjzm9WBQJot2mSkBBwuWHRNnY+9Q==", "3f83bf33-769b-4d68-ba3a-127df55f4e17", new DateTime(2025, 10, 19, 20, 33, 3, 283, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2d7549b3-96ee-4027-a0e1-05136a83f461", "AQAAAAIAAYagAAAAEEIRJz/h8Dw+oE76nUnPzpPIgt7jTWU4urw5QalC/9jwaOkXuzLpBDewiO1hzb08LQ==", "7722def7-ee5d-4c1e-8094-7fb2783f87a4", new DateTime(2025, 10, 19, 20, 33, 4, 860, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f96bfe35-18eb-4b95-a346-8ca1da73a599", "AQAAAAIAAYagAAAAEBoNhxQ/4+UFi8IJJzlKeH1nlxyA34Yg62Ro30j7M4gmOpA6pzwuv36nsFLCtdREMw==", "528af4bc-932a-4d3a-886e-fabc7bce55d5", new DateTime(2025, 10, 19, 20, 33, 4, 903, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "93026c03-3ae3-4d9e-b577-b31ed03b44e6", "AQAAAAIAAYagAAAAEECjzwSnlVFyS3RcbMjZpzw/CD9jHCqysyD1RTduxTV2ahCUXV1fSZgxNwfu+kAW1A==", "9c188932-2d00-460e-9343-7707affafda5", new DateTime(2025, 10, 19, 20, 33, 4, 948, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0093f72f-cfac-47c9-99df-9e8e13e4e913", "AQAAAAIAAYagAAAAEPlOMGeI1kxZLGbmzLoYZd8Hql2zghZZVQ6gBeN73dty21AizSU4KGjBbotKZm6sOQ==", "7bc35738-560c-40a8-99c7-c33c92b9abc0", new DateTime(2025, 10, 19, 20, 33, 4, 992, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5ce1ed78-4cb0-482f-8ed9-1c2cbcd6fe3f", "AQAAAAIAAYagAAAAEBgcqWoTpCNcLRq+pCbPfCOCM5SnUVobQHa061Oco/54J8TSrCkOIaOoSsH+f3Sm/w==", "f65b8cd3-cd45-475a-90df-ef6fb83babff", new DateTime(2025, 10, 19, 20, 33, 5, 37, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4d1efa2e-06c2-4363-8386-10362eab434e", "AQAAAAIAAYagAAAAEIFnVo7qudCtQvNAg7ek/h8X4eoohwcssJjdiMRDI3WcoRlxKPDP3kaug2YJdU0SSg==", "038d0829-17ba-4762-8a97-c5465ae81e80", new DateTime(2025, 10, 19, 20, 33, 5, 81, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "53233bee-a880-4c72-8838-79f90e5d891d", "AQAAAAIAAYagAAAAEBAl9sPnofJL7RAEv5BiLrPrqvsxHlnTJ+XN+ULz7gXfqzpKypqunG7p7t9AAbmvvA==", "214e448f-140f-48ed-a275-2510075c9ee9", new DateTime(2025, 10, 19, 20, 33, 5, 124, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "85f9a66c-f9e1-4a25-b2be-1f4546e16b08", "AQAAAAIAAYagAAAAECAPXhNR7VgAI4THIrrl/6ikhKWh8gwS9OGS0TiHd5E7XKTy5RrVmmwR7d0ug3Mkdw==", "ec655d1e-fb52-4405-9b03-ab91a0e4bc98", new DateTime(2025, 10, 19, 20, 33, 5, 169, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e82a7278-3e18-4ae9-b3c5-194ae5506324", "AQAAAAIAAYagAAAAEDGLULK94gxU/6eEVVexsER4M4ydgAEtfIISfa2ZqOWuir+gVMyu+AovfUONxZAmIQ==", "85665315-21bf-41f5-8179-da100982b3e2", new DateTime(2025, 10, 19, 20, 33, 5, 213, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ed61f91a-b734-405a-a69f-18dc9359f2a4", "AQAAAAIAAYagAAAAENO4OLz7oCOI7PO1L8IPqu0SfYdneVraiARfgJlhFeKbybeXKI7JIYf5E2BSTqcMbw==", "d884927e-a075-476b-9856-ea82cffb0120", new DateTime(2025, 10, 19, 20, 33, 5, 258, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c82323a5-071c-447d-a8f6-5e349c8d2bf7", "AQAAAAIAAYagAAAAEFFxS+QfLUNdBNYaJwL8sces8yO4+Iq88ENAGbz3n7Go+0bM51QT+49iTerxSnZ6Dw==", "215ddaca-678d-401c-a397-ccf4ff603f78", new DateTime(2025, 10, 19, 20, 33, 3, 327, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "92977cf8-d289-4660-b6e2-08e9569db7b5", "AQAAAAIAAYagAAAAEG/5JqYKhrrXwvM+/357gM5wl9bPtngqekx9Re5Y1Enn5j7igze8dN4XfxXBartByA==", "96f825ba-2a6d-4814-9dda-dd24b0146cb5", new DateTime(2025, 10, 19, 20, 33, 5, 302, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "98ae1d3f-1ec7-4525-84db-1745a9955300", "AQAAAAIAAYagAAAAECeUwM/qmEqlIcmbJ4cFwxSDfdRBojg8KFbtze4bMtN1YczyHHBWdv958xYvUxaa3w==", "678146f7-0b7c-4047-b411-624b028f01c6", new DateTime(2025, 10, 19, 20, 33, 3, 370, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3bfadd14-087a-4406-bba1-f2665ce5bda4", "AQAAAAIAAYagAAAAECawJxbgfz18Dxh+E/Or/3jN2r6fv1moGVVp1QrHx3JBZBO8NcN142VcnYd7L4KNWQ==", "2a1840ca-21d6-463f-baef-2df9d801b7f1", new DateTime(2025, 10, 19, 20, 33, 3, 414, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "36d3add4-7605-4e24-83c7-dca58615bd78", "AQAAAAIAAYagAAAAEMeIV+1N9/0t4CsFEX6mlz367kFXmF/TT4O1AlU80IJKmr9D0WGxLR110LIFTsPmtQ==", "1441c8b6-bbd0-4392-bfdf-36d0f0d9bce2", new DateTime(2025, 10, 19, 20, 33, 3, 457, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "21a9e55a-439e-42b5-bea3-e6de71b2c777", "AQAAAAIAAYagAAAAEC+qudxpsj4PXNfinB5GVC68wgZH5mgh4pVkhfb5zduvCU6XuTzJYBRWF94K+aR18w==", "fc033ce9-3486-497a-a3b6-7aab8abfac1f", new DateTime(2025, 10, 19, 20, 33, 3, 501, DateTimeKind.Local).AddTicks(4913) });
        }
    }
}
