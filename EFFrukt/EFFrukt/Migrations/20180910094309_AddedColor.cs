using Microsoft.EntityFrameworkCore.Migrations;

namespace EFFrukt.Migrations
{
    public partial class AddedColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Fruits",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Fruits");
        }
    }
}
