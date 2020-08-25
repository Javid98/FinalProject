using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Data.Migrations
{
    public partial class changeAgeToBirthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "UserDetails");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "UserDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "UserDetails");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "UserDetails",
                nullable: false,
                defaultValue: 0);
        }
    }
}
