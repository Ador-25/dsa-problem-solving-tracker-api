using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA_Tracker.Migrations.IdentityDb
{
    public partial class CompanyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Companies",
                table: "Problems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Companies",
                table: "Problems");
        }
    }
}
