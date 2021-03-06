using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceManagerBackend.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "test",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tets",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "tets",
                table: "Devices");
        }
    }
}
