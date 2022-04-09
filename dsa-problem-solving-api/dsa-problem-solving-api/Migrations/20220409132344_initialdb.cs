using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dsa_problem_solving_api.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    PlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlatformUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "Problems",
                columns: table => new
                {
                    ProblemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionNo = table.Column<int>(type: "int", nullable: false),
                    ProblemDifficulty = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Solution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeedRepeat = table.Column<bool>(type: "bit", nullable: false),
                    PlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problems", x => x.ProblemId);
                    table.ForeignKey(
                        name: "FK_Problems_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Problems_PlatformId",
                table: "Problems",
                column: "PlatformId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Problems");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
