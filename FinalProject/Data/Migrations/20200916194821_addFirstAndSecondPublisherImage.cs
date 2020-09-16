using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Data.Migrations
{
    public partial class addFirstAndSecondPublisherImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstPublisherImage",
                table: "Bios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondPublisherImage",
                table: "Bios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstPublisherImage",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "SecondPublisherImage",
                table: "Bios");
        }
    }
}
