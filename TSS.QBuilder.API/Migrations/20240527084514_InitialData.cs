using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TSS.QBuilder.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ControlType",
                columns: new[] { "Id", "ControlName" },
                values: new object[,]
                {
                    { new Guid("32530f63-9047-4c4d-81c3-1e1a0ed78bca"), "Control Type 3" },
                    { new Guid("f5c9f52a-f7bd-4c65-a144-01cd4caa3426"), "Control Type 1" },
                    { new Guid("f74b3df6-a04d-4351-8d5b-2d757688d7d0"), "Control Type 2" }
                });

            migrationBuilder.InsertData(
                table: "QuestionSet",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2a14846f-46b3-4f00-8d3d-dd77a9bf6a08"), "This is the first question set", "Question Set 1" },
                    { new Guid("71a30165-923f-43d2-bcc4-ceb2e5d0aeac"), "This is the second question set", "Question Set 2" },
                    { new Guid("c1123783-5004-4fe7-af36-2a9ffd183641"), "This is the third question set", "Question Set 3" }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "ControlTypeId", "QuestionSetId", "QuestionSubText", "QuestionText" },
                values: new object[,]
                {
                    { new Guid("6ddd1742-8b20-47e9-8c79-fd686e9ab2c9"), new Guid("f74b3df6-a04d-4351-8d5b-2d757688d7d0"), new Guid("71a30165-923f-43d2-bcc4-ceb2e5d0aeac"), "This is the second question", "Question 2" },
                    { new Guid("7f430543-7f81-450d-aee0-660ad9e10e9f"), new Guid("32530f63-9047-4c4d-81c3-1e1a0ed78bca"), new Guid("c1123783-5004-4fe7-af36-2a9ffd183641"), "This is the third question", "Question 3" },
                    { new Guid("d41217c6-2aae-402b-99d2-83ba7ee13f10"), new Guid("f5c9f52a-f7bd-4c65-a144-01cd4caa3426"), new Guid("2a14846f-46b3-4f00-8d3d-dd77a9bf6a08"), "This is the first question", "Question 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("6ddd1742-8b20-47e9-8c79-fd686e9ab2c9"));

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("7f430543-7f81-450d-aee0-660ad9e10e9f"));

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("d41217c6-2aae-402b-99d2-83ba7ee13f10"));

            migrationBuilder.DeleteData(
                table: "ControlType",
                keyColumn: "Id",
                keyValue: new Guid("32530f63-9047-4c4d-81c3-1e1a0ed78bca"));

            migrationBuilder.DeleteData(
                table: "ControlType",
                keyColumn: "Id",
                keyValue: new Guid("f5c9f52a-f7bd-4c65-a144-01cd4caa3426"));

            migrationBuilder.DeleteData(
                table: "ControlType",
                keyColumn: "Id",
                keyValue: new Guid("f74b3df6-a04d-4351-8d5b-2d757688d7d0"));

            migrationBuilder.DeleteData(
                table: "QuestionSet",
                keyColumn: "Id",
                keyValue: new Guid("2a14846f-46b3-4f00-8d3d-dd77a9bf6a08"));

            migrationBuilder.DeleteData(
                table: "QuestionSet",
                keyColumn: "Id",
                keyValue: new Guid("71a30165-923f-43d2-bcc4-ceb2e5d0aeac"));

            migrationBuilder.DeleteData(
                table: "QuestionSet",
                keyColumn: "Id",
                keyValue: new Guid("c1123783-5004-4fe7-af36-2a9ffd183641"));
        }
    }
}
