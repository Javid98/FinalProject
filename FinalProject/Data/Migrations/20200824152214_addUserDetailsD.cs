using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Data.Migrations
{
    public partial class addUserDetailsD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "UserDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "UserDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "UserDetails");
        }
    }
}
