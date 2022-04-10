using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dsa_problem_solving_api.Migrations
{
    public partial class difficultyadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Problems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Problems");
        }
    }
}
