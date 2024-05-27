using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TSS.QBuilder.API.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControlType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ControlName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    QuestionSubText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ControlTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionSetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_ControlType_ControlTypeId",
                        column: x => x.ControlTypeId,
                        principalTable: "ControlType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Question_QuestionSet_QuestionSetId",
                        column: x => x.QuestionSetId,
                        principalTable: "QuestionSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_ControlTypeId",
                table: "Question",
                column: "ControlTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionSetId",
                table: "Question",
                column: "QuestionSetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "ControlType");

            migrationBuilder.DropTable(
                name: "QuestionSet");
        }
    }
}
