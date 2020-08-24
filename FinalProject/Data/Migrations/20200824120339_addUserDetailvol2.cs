using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Data.Migrations
{
    public partial class addUserDetailvol2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetail_AspNetUsers_AppUserId",
                table: "UserDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDetail",
                table: "UserDetail");

            migrationBuilder.RenameTable(
                name: "UserDetail",
                newName: "UserDetails");

            migrationBuilder.RenameIndex(
                name: "IX_UserDetail_AppUserId",
                table: "UserDetails",
                newName: "IX_UserDetails_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetails_AspNetUsers_AppUserId",
                table: "UserDetails",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetails_AspNetUsers_AppUserId",
                table: "UserDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails");

            migrationBuilder.RenameTable(
                name: "UserDetails",
                newName: "UserDetail");

            migrationBuilder.RenameIndex(
                name: "IX_UserDetails_AppUserId",
                table: "UserDetail",
                newName: "IX_UserDetail_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDetail",
                table: "UserDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetail_AspNetUsers_AppUserId",
                table: "UserDetail",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
