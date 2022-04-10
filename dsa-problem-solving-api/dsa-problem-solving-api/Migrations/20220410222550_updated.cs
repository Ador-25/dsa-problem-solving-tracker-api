using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dsa_problem_solving_api.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProblemDifficulty",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Platforms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProblemDifficulty",
                table: "Problems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Source",
                table: "Platforms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
