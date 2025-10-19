using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class addStatusQuiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 1L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 3L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 5L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 6L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 7L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 8L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 9L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 10L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 11L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 12L,
                column: "Status",
                value: 1);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Quizzes");

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ad1ab52e-717a-4d7a-8cc4-56ade882ff19", "AQAAAAIAAYagAAAAEAKsRSQD3714SAOga3rQWLbsoiICBvE72OpkkFMaul2d1XN2NT6nVMfJRAyUoFG0Lw==", "d58c0700-399c-4036-9391-16a24a2d9bdd", new DateTime(2025, 10, 18, 9, 59, 45, 793, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1c22eece-6b84-4530-8776-a0a56fafd928", "AQAAAAIAAYagAAAAECtuRApsoWqdVYx4FUFVgqlDbmgzAOv0Y6VA2hfCNnO8WE9tFMY2ULctpHJeSq0UjQ==", "c2c7598f-9b01-4968-96b2-1a88267edeef", new DateTime(2025, 10, 18, 9, 59, 46, 649, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c94631d9-a87e-4c41-9302-1b6334256837", "AQAAAAIAAYagAAAAEOkg440ir5eWvvHQekiiiAWP8p6600pz2ekUUZUAn9x52R+2ZotnhTLTSAcEiDSy9Q==", "083d7409-88a0-45d2-82e0-07a07588a530", new DateTime(2025, 10, 18, 9, 59, 46, 736, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2b965231-8c7d-4e2a-b406-82e79e193c09", "AQAAAAIAAYagAAAAEEgzHXqu/OGLB33TebTPNpyS7/hmfeHM0Q8RwJNM7ksipyNGroWUDUhCPV8NaRATyg==", "cd697d96-f353-4ba6-89aa-282750fc8748", new DateTime(2025, 10, 18, 9, 59, 46, 831, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "724d07ad-e368-4de4-81fb-dea23acd367d", "AQAAAAIAAYagAAAAEIN+mxWtIDaRx7g4MYTmWWWf7hMFzLhGNKjMtMMGcCxbzNHbjM2EGbFvRGnrpTCjMQ==", "5810ed4f-71f1-4417-b072-42899fec8529", new DateTime(2025, 10, 18, 9, 59, 46, 920, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9b580e57-f985-401e-b6c0-2fc889bb0246", "AQAAAAIAAYagAAAAEIx4xlEeapAKHbgco2AKOB0CK+zq8zmbPZiMWK3WwF0zL6COd/FhGdhC9Qtpx0vAPw==", "e0e9fc29-d4f0-48ce-8f7c-40fb17b389fb", new DateTime(2025, 10, 18, 9, 59, 47, 10, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "53f67301-ed4b-485d-b86a-f0c6a0d864f1", "AQAAAAIAAYagAAAAEAUA9yOnBocKaHTtViAueGw/hXCdAVRjvO0aTDPrg2uAd8nTO2Q7UryTzbn+ImzQrg==", "37e7b8e5-5570-4e4b-a9ce-dce0b05a0421", new DateTime(2025, 10, 18, 9, 59, 47, 112, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bbbdb14f-02c5-43c3-80d2-4b9c30173774", "AQAAAAIAAYagAAAAEGeLhVFQhVPsqNG1yzoQCfR/7oYuFRLPAHziCW6Krmg5EDOnMla5q2Vh0u8iuZnNdg==", "f17a81b1-d502-42cb-91a4-e207fb2a9a8d", new DateTime(2025, 10, 18, 9, 59, 47, 204, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c6608ed0-d023-4f20-9883-8320b930d7bf", "AQAAAAIAAYagAAAAEFtIZstzJPqwxdylraPLd6uJ3K+gkk8jE8vSEEni/BfE9U4wcUHoS5OliCxg8C8Qew==", "3a4504e7-0f4f-4ed6-9805-4d99e9f4f8c8", new DateTime(2025, 10, 18, 9, 59, 47, 289, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f13c3715-8299-4590-baef-a0878e5c1f54", "AQAAAAIAAYagAAAAEFbUHtqLel7gjMHTIU/glaFSkFAqznPF8QJ03TQPPa+fCbDwOqCxTdn5w0+zZmuoHw==", "5cf55d16-994a-4fae-b41b-e6e3853244ee", new DateTime(2025, 10, 18, 9, 59, 47, 382, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3c74980f-377f-4d53-a8ec-263e08ca5fc2", "AQAAAAIAAYagAAAAEG91BujU2H1VNe7wPDDBMVN8KXBajhokSE19CQJzauQCHjihYPzURCbYqcWMQZH/lg==", "ee17a41a-a0b3-4bc0-aadd-5f1649f067dd", new DateTime(2025, 10, 18, 9, 59, 47, 485, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "19dc1b99-e619-455b-bdae-a990457c3dc3", "AQAAAAIAAYagAAAAEAfjELgGlPVgmm15h3FIURPAnl8nmY6OVZahwYu2zezXVMS/+MkhhrCc6pgj4qhFxg==", "e99960f0-a631-4bf3-8cfd-ded068de1b38", new DateTime(2025, 10, 18, 9, 59, 45, 882, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9b409a41-ec31-4add-99a2-52a8dc768fda", "AQAAAAIAAYagAAAAEEkG0ep6IG/Moq7SBGONdKbelgHE9Bj8vedcDVgm0Ox+crc3chWKBjNlQgPmuf7h4Q==", "a9c26324-eac6-4fd8-a828-a2008a1e76b0", new DateTime(2025, 10, 18, 9, 59, 47, 573, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4515121c-5c4a-42e5-9ee2-4c218b9538bf", "AQAAAAIAAYagAAAAEFBXu4xEeY4u4ken86MS3M5s6w2hTJzIfE36TFV8NPBSls7OcDagWkWOQFvKdAz2GA==", "8e7c5f1c-797e-4c7c-9f64-bd0d363ac051", new DateTime(2025, 10, 18, 9, 59, 47, 673, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7af74b32-ef23-4d55-a5e7-115f5fc1e79a", "AQAAAAIAAYagAAAAEEJxXDlyvRA2LfuXROHJU/lTVm4aZoNRgVcynJTUUf3b8gUeYBRJUjWCGiAPz+ULRA==", "af0c7ba8-568e-4221-b4fa-842ddf1e5707", new DateTime(2025, 10, 18, 9, 59, 47, 781, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ebf39650-73e1-40a4-887d-3abf9169010e", "AQAAAAIAAYagAAAAEPivVZbvd45phOtbN6/8657f89+63bmoQsYO6gimbIWMxq+UdrUAjZlp4aQjvjoHMg==", "f54a44ed-70d9-4ea0-8190-62fb57a58c0e", new DateTime(2025, 10, 18, 9, 59, 47, 880, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "da7797d3-bbce-4c56-b839-bb415c572e6b", "AQAAAAIAAYagAAAAEAY0AfZ+W8/T3jhEh6lBbfN34WMvTRtAXAyp0rZUcsOmdJbkSVtOOZGu+1bgArPRRQ==", "cbe68bfb-72be-4235-889f-a52f0d27b319", new DateTime(2025, 10, 18, 9, 59, 47, 966, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d0a3b1c5-5bac-4d5c-a7ae-a160703c09fd", "AQAAAAIAAYagAAAAEHQlb7QQ7TRe/Ik4PMhz91kp59i6ATzITM3vZ0z5bhzRyVqS+LRUVJ8eHbsX5Kt5iQ==", "430e693c-7f5a-4010-9bcd-836d2e8778d2", new DateTime(2025, 10, 18, 9, 59, 48, 76, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d64fec05-2c38-4a6f-9437-0bc67cb0ae04", "AQAAAAIAAYagAAAAEMrF/tzmQlwFWWQtl1liqNRmbtRVkywAEuZM3jITt5dn+DwlfMfIF4CwwB7jwZPZyw==", "e3e70d06-6dce-4ed5-80b1-b6d9aa5c794c", new DateTime(2025, 10, 18, 9, 59, 48, 184, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "40d0874b-78f8-4a54-a484-6020db8165fe", "AQAAAAIAAYagAAAAECGoRllmdJTzV6Lb/b4zdo9ya5IO8zh5KQjPYbK4jurCLG0+EyY5UNqjgPG0QR346A==", "22c9a26d-2025-4a2e-854c-a859e69878d5", new DateTime(2025, 10, 18, 9, 59, 48, 269, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "985907b7-6bc0-459e-9ee3-a47156b5d21a", "AQAAAAIAAYagAAAAELNT0tTmhACRpfX8/RaoD1bEir/m2mVVpEMV7uROJkwAMsHpvi3tuQAv6E6Z+ovNPQ==", "2e1126af-4fb4-47f4-a39e-d3e64283271b", new DateTime(2025, 10, 18, 9, 59, 48, 357, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "df7c7ce2-5a82-4a46-8ab6-998fe62d3777", "AQAAAAIAAYagAAAAEH75OXdeMcDoE6X1mW4K2YqCqt4JaW3wtbbtumiuvaBAbk4OeGJ+DTxgpWg0IbGZ2w==", "381b168c-3647-4ec4-9bf7-36bd1c0fb540", new DateTime(2025, 10, 18, 9, 59, 48, 451, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b6b5e115-7adf-47b7-a100-0c427bb038e7", "AQAAAAIAAYagAAAAEB1IhWXLaBtEXhlSrq2XDY1OMVQB7Tm4Xj5S4tdR/7OqnrhY3FodcubzZTAJcGqdzA==", "5678c8b3-a372-4d70-ac0d-906f842fef3e", new DateTime(2025, 10, 18, 9, 59, 45, 975, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "58a644f4-01bb-4549-834b-8927fe292bc6", "AQAAAAIAAYagAAAAEHawQ+n+FN3it+ViLHA+5LxFGlILGCw6rDaYkIr72oQMy4p3OpznBjJIwhnkZGaKVQ==", "d35438ed-106b-49a1-97b7-b44567a8033d", new DateTime(2025, 10, 18, 9, 59, 48, 542, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a7cd810f-0343-4a7b-b935-e80ee4005f02", "AQAAAAIAAYagAAAAEEnvuTSWeAW9GAtV/xhYRwiKmcy/0nlNOFYKsMH1d5mOs6cz9zsOO7ZSGIoo91qetA==", "92c506c2-aea3-4f08-96f8-2bfee67fe2d6", new DateTime(2025, 10, 18, 9, 59, 48, 630, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ab262f0d-9fe5-47ad-842d-774792f84c3c", "AQAAAAIAAYagAAAAEC7MxhmAEdx703eoLAdcVs8H6zQvJHRRPnkO3jluHkxY3gC8qxFXf6DxlUq/uMgPhQ==", "4fedee01-b115-4c5d-9503-5c73fa02ad4b", new DateTime(2025, 10, 18, 9, 59, 48, 726, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7659e591-7336-485b-ab18-5a4ebc33d868", "AQAAAAIAAYagAAAAEG7syervkJljwh2G07oxlRfpFacBg9LidghJopWIJt03lAXyIvTv+RY3LA6rM9/JzA==", "dee88036-2956-4bbd-85a1-69a1d20ee024", new DateTime(2025, 10, 18, 9, 59, 48, 815, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8efa1350-f926-445a-a66d-5e1b18a85312", "AQAAAAIAAYagAAAAEALBfWnJyd/eAE4v3Z5DsyngMna3hP3xbKDNgK/1BVWhcL+APKyOTJkgjTM4LxqL1g==", "6bb1852c-c5cc-40a8-97ec-6c519303b33d", new DateTime(2025, 10, 18, 9, 59, 48, 909, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a731b283-c453-4bbd-96e0-32e46256371a", "AQAAAAIAAYagAAAAEMre3Foq8DLGR0i2aK4vaQTREH6Mo1BL33c7o4d2vVdzh0geS88rqQTG+65trWUfNQ==", "c16a1117-5b47-4902-8e55-a428d1b830ff", new DateTime(2025, 10, 18, 9, 59, 49, 18, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7f42e61a-bc7b-496e-837e-9099962f232b", "AQAAAAIAAYagAAAAEHSZ0G95fiXbwAreH4h+NBvrmyh7dchh/l3YGRezt9/HDGih+SJ06DuJMdLq8Dckhg==", "73c68655-f189-4f67-bcef-7e5052f14e06", new DateTime(2025, 10, 18, 9, 59, 49, 406, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "21d8d31a-a012-4e3c-a1a1-da7a0b4f7f9d", "AQAAAAIAAYagAAAAEF4Lzu2oLvq2BekT5eN8ZMc6HsW8Syb1vOLhGQ1N6BRdHRhKI+IXIIGIMPPwfhvhBQ==", "91ace1ff-7e40-43af-a4c3-994ef6024c11", new DateTime(2025, 10, 18, 9, 59, 49, 513, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bbacf1db-c425-4fd6-a728-bb8dc61e7480", "AQAAAAIAAYagAAAAEDE7hkHUhYXzmL4je0WQa3sXL1Ms+aRRKsF+tPiUzPlUqdbPI9JRldIwrZEyE+Ortg==", "f373965f-3b97-4813-8e14-15e37219b8fe", new DateTime(2025, 10, 18, 9, 59, 49, 609, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2d6377f4-83ba-4787-bb73-b2b87b086f4f", "AQAAAAIAAYagAAAAEB92Opp9h5MaSo93BV468ENBe9OqDwxTsiE3zt0umWNIFiPhLSSKtqVVDHT7o5rWSQ==", "c3eee590-3aaf-44bf-9e02-a57cd59f2a85", new DateTime(2025, 10, 18, 9, 59, 49, 702, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b0c29ce8-13a6-44fc-bdeb-20ae6ea8d591", "AQAAAAIAAYagAAAAEJ+fvJ57Io7j1Kp2ly3XM+hOTj8EpvNlMHYg7WglGxUcA727cv2fi9Ygeo++e/LRJA==", "416897cd-de94-47ed-a6e7-2754eddb9d02", new DateTime(2025, 10, 18, 9, 59, 46, 97, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "24e1a8ba-6264-4d2c-bbe2-5f9d69a77f6f", "AQAAAAIAAYagAAAAEPAeZmcgPVdAfBs6u81NFFU2E4b9LIYhKYQ5sqwFcAC50pNzPEUtU6/T2HWuyAinlQ==", "087b0019-eacc-4c2a-b36b-9bbe99f72608", new DateTime(2025, 10, 18, 9, 59, 49, 820, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f5f691ce-09f8-4555-874b-f493b4331287", "AQAAAAIAAYagAAAAEDnWSjEa0hRvmvTGorbyofFTbtwo42OYKqkrKa0ciaTqpu1z06ptougUt8TdXLDUNA==", "c0298e97-bd1e-4d0d-9f04-121c9201c20e", new DateTime(2025, 10, 18, 9, 59, 49, 917, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8873e4d2-52b2-4a7b-88ad-232fdab49eb5", "AQAAAAIAAYagAAAAEAVuOSRMtTS1K20lvDl3sW6r98hnNzSEqEBvt80dVytw/4HYB51/6iKDQm/0LMsFcg==", "0b50c2ca-8340-4b4c-8090-f03607f5000b", new DateTime(2025, 10, 18, 9, 59, 50, 20, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "29701f9f-c54c-4dbd-a98d-d303a5180964", "AQAAAAIAAYagAAAAEMC/zdmpNDFWkGw5U8v1n+PZwUGee7pog+K8PhTn4z0LI/Jkg97xfSudubR/go/z7A==", "c41c207b-973f-4ca2-afbf-bd8e5bcdee61", new DateTime(2025, 10, 18, 9, 59, 50, 121, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bcbdacca-70a8-4d25-85b7-28e52c4de43d", "AQAAAAIAAYagAAAAEKp6P4gGkksHE5Jh6vuBnABAR8wa3BBFYlFU9uzvx24lS6ZrdHUiRfmXyCsV8qIlYg==", "4e663f64-3e42-4c58-a71e-e6cd1e3d5f16", new DateTime(2025, 10, 18, 9, 59, 50, 219, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8873fd68-912e-4bad-a3e2-e36a00d9bee6", "AQAAAAIAAYagAAAAECqrcy8vwPFxm7Me0J5rbe2c1HpzOZggj+8nU5GhCM1MF0P47G6RFSZ51LALJ2Ahgg==", "e0c33a0f-0c8a-4a75-8cd3-c8064b34d5f4", new DateTime(2025, 10, 18, 9, 59, 50, 310, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9929a191-b6db-41e5-9f5d-fc2ae1824953", "AQAAAAIAAYagAAAAEFjSaCxPO3VsjAQss9Cz8OUg+AMfGOTEcenm4eK+HxKjKVs3yyyt7sDujdd6q0ftOg==", "926ef144-c57a-4701-85ee-d4e52f42486f", new DateTime(2025, 10, 18, 9, 59, 50, 412, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "92ba93cc-edb1-47c6-b798-8f31eee4d9c6", "AQAAAAIAAYagAAAAEOusoF6yXI/vu9V++se+qlZLfqb16QPV4quNzFhlGM15D19rZBABbUHPXB4+93nRcA==", "d9c0d494-db90-44a7-bf98-8c74714bc0c5", new DateTime(2025, 10, 18, 9, 59, 50, 533, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ff2af1b6-977b-41ea-8d63-6d614ea41e8c", "AQAAAAIAAYagAAAAEBSppH9raiigsQcjn7rITJ/G4x+/tJW7FB3Nj2InGkE3mEiWSC+QKpMZ8g/UEacnCg==", "4f4e7d16-4b2d-43d7-971a-4686db57bb4e", new DateTime(2025, 10, 18, 9, 59, 50, 623, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c91b4b89-ef56-4d53-b418-04d0e8583558", "AQAAAAIAAYagAAAAEOSzmsSfPu1kLMGuJjUQr5W8uhNEdyq5qVyq5SbUSjsgHeJCbdakp6PPKgastZrcWw==", "48a55b6b-264f-4bdf-97f3-c7c1c09cb077", new DateTime(2025, 10, 18, 9, 59, 50, 713, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "36fd1f3f-3dcb-4205-bb2c-97d9b8440c08", "AQAAAAIAAYagAAAAEAzkqasSosQcEDpaKiY9xrvJbPT2NvNxiTavAclPsvHP5D3Mqz4TAXpMa0iKqv8Fkg==", "e034f190-b5c6-45d8-993e-f664b24fe533", new DateTime(2025, 10, 18, 9, 59, 46, 183, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3fd9c690-fc6e-4cb9-a16e-d179c74c3506", "AQAAAAIAAYagAAAAEG/KQxSXM0BX48fuarMXK3+QOE5CiuTHySGUb06GWHpsYJJjQHiA2My30H3jimBKkg==", "24f252fa-70be-427c-ae7d-6b589ae156f7", new DateTime(2025, 10, 18, 9, 59, 50, 837, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d2d8a1be-d7bd-4e8b-8711-f3c909c922e9", "AQAAAAIAAYagAAAAEPrv0XSK8uyFGSuooxnZKuz52dfnq2Vs1DhKCZEeEfbL5UqcmCaqFjwTK7UOuS9pIA==", "c7012a59-3c9d-40e1-b35f-3eb1547b607b", new DateTime(2025, 10, 18, 9, 59, 46, 282, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "334501c6-eefd-47bd-ab09-37eb60d62fae", "AQAAAAIAAYagAAAAEGA5YEuQoi/B4dbWufi2Dhs3DR4LZ5pUYsJJyEd/Td04/ySv5bXaAVkh7fig5pB83w==", "f0511a4d-4d56-453d-8691-eabdd3562c7f", new DateTime(2025, 10, 18, 9, 59, 46, 373, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9be35e74-cf26-416a-a508-3fa134bb2ff8", "AQAAAAIAAYagAAAAEDFNpKWJmowz7d+SH0PSFYq4eNDJSdCyns2y1F+uMWUT+H7NfX8dmnoki+4qmWNMRA==", "0e0cddaf-b450-46ba-a6f8-d12dd76b73fd", new DateTime(2025, 10, 18, 9, 59, 46, 459, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bb0a50c4-e2df-4f32-9060-df9e722a6f30", "AQAAAAIAAYagAAAAEKwbLpGrfQP8IK4NTqK4+mJvAwOqn8dEOrosVcfg2XzV8ngvUS77GH40XMyIvQ50Sg==", "76d234c4-46aa-44b6-b2fd-32bd6ae3542d", new DateTime(2025, 10, 18, 9, 59, 46, 558, DateTimeKind.Local).AddTicks(5059) });
        }
    }
}
