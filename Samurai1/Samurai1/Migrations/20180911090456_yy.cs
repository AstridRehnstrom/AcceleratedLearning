using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Samurai1.Migrations
{
    public partial class yy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HairStyles");

            migrationBuilder.AddColumn<int>(
                name: "HairStyle",
                table: "Samurais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuoteType",
                table: "Quotes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HairStyle",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "QuoteType",
                table: "Quotes");

            migrationBuilder.CreateTable(
                name: "HairStyles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SamuraiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairStyles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HairStyles_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HairStyles_SamuraiId",
                table: "HairStyles",
                column: "SamuraiId");
        }
    }
}
