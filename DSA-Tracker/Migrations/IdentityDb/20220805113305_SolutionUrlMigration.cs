using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA_Tracker.Migrations.IdentityDb
{
    public partial class SolutionUrlMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solutions");

            migrationBuilder.AddColumn<string>(
                name: "SolutionUrl",
                table: "Problems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SolutionUrl",
                table: "Problems");

            migrationBuilder.CreateTable(
                name: "Solutions",
                columns: table => new
                {
                    SolutionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProblemId = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    SolutionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolutionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SolutionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeComplexity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solutions", x => x.SolutionId);
                    table.ForeignKey(
                        name: "FK_Solutions_Problems_ProblemId",
                        column: x => x.ProblemId,
                        principalTable: "Problems",
                        principalColumn: "ProblemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_ProblemId",
                table: "Solutions",
                column: "ProblemId");
        }
    }
}
