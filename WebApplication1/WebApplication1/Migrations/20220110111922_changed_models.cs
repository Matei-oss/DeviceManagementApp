using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceManagerBackend.Migrations
{
    public partial class changed_models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Spaces",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_UserId",
                table: "Spaces",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Users_UserId",
                table: "Spaces",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Users_UserId",
                table: "Spaces");

            migrationBuilder.DropIndex(
                name: "IX_Spaces_UserId",
                table: "Spaces");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Spaces");
        }
    }
}
