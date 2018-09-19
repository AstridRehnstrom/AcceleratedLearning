using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckPoint06.Migrations
{
    public partial class RavioliAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ravioli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Packed = table.Column<DateTime>(nullable: false),
                    BestBefore = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ravioli", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RavioliInSpaceship",
                columns: table => new
                {
                    SpaceshipId = table.Column<int>(nullable: false),
                    RavioliId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RavioliInSpaceship", x => new { x.RavioliId, x.SpaceshipId });
                    table.ForeignKey(
                        name: "FK_RavioliInSpaceship_Ravioli_RavioliId",
                        column: x => x.RavioliId,
                        principalTable: "Ravioli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RavioliInSpaceship_Spaceships_SpaceshipId",
                        column: x => x.SpaceshipId,
                        principalTable: "Spaceships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RavioliInSpaceship_SpaceshipId",
                table: "RavioliInSpaceship",
                column: "SpaceshipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RavioliInSpaceship");

            migrationBuilder.DropTable(
                name: "Ravioli");
        }
    }
}
