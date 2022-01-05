using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceManagerBackend.Migrations
{
    public partial class Added_FVersion_To_Device : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirmwareVersion",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirmwareVersion",
                table: "Devices");
        }
    }
}
