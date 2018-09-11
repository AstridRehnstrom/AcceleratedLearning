using Microsoft.EntityFrameworkCore.Migrations;

namespace Samurai1.Migrations
{
    public partial class NewNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HairStyles_Samurais_SamuraiIdId",
                table: "HairStyles");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samurais_SamuraiIdId",
                table: "Quotes");

            migrationBuilder.RenameColumn(
                name: "SamuraiIdId",
                table: "Quotes",
                newName: "SamuraiId");

            migrationBuilder.RenameIndex(
                name: "IX_Quotes_SamuraiIdId",
                table: "Quotes",
                newName: "IX_Quotes_SamuraiId");

            migrationBuilder.RenameColumn(
                name: "SamuraiIdId",
                table: "HairStyles",
                newName: "SamuraiId");

            migrationBuilder.RenameIndex(
                name: "IX_HairStyles_SamuraiIdId",
                table: "HairStyles",
                newName: "IX_HairStyles_SamuraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_HairStyles_Samurais_SamuraiId",
                table: "HairStyles",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HairStyles_Samurais_SamuraiId",
                table: "HairStyles");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes");

            migrationBuilder.RenameColumn(
                name: "SamuraiId",
                table: "Quotes",
                newName: "SamuraiIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Quotes_SamuraiId",
                table: "Quotes",
                newName: "IX_Quotes_SamuraiIdId");

            migrationBuilder.RenameColumn(
                name: "SamuraiId",
                table: "HairStyles",
                newName: "SamuraiIdId");

            migrationBuilder.RenameIndex(
                name: "IX_HairStyles_SamuraiId",
                table: "HairStyles",
                newName: "IX_HairStyles_SamuraiIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_HairStyles_Samurais_SamuraiIdId",
                table: "HairStyles",
                column: "SamuraiIdId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samurais_SamuraiIdId",
                table: "Quotes",
                column: "SamuraiIdId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
