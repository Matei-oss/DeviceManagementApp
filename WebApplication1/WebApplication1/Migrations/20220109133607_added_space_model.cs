using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceManagerBackend.Migrations
{
    public partial class added_space_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SpaceId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Spaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spaces", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_SpaceId",
                table: "Rooms",
                column: "SpaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Spaces_SpaceId",
                table: "Rooms",
                column: "SpaceId",
                principalTable: "Spaces",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Spaces_SpaceId",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "Spaces");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_SpaceId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SpaceId",
                table: "Rooms");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
