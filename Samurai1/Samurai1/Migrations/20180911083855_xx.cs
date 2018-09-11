using Microsoft.EntityFrameworkCore.Migrations;

namespace Samurai1.Migrations
{
    public partial class xx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleLogs_Samurais_SamuraiId",
                table: "BattleLogs");

            migrationBuilder.RenameColumn(
                name: "SamuraiId",
                table: "BattleLogs",
                newName: "BattleId");

            migrationBuilder.RenameIndex(
                name: "IX_BattleLogs_SamuraiId",
                table: "BattleLogs",
                newName: "IX_BattleLogs_BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs");

            migrationBuilder.RenameColumn(
                name: "BattleId",
                table: "BattleLogs",
                newName: "SamuraiId");

            migrationBuilder.RenameIndex(
                name: "IX_BattleLogs_BattleId",
                table: "BattleLogs",
                newName: "IX_BattleLogs_SamuraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleLogs_Samurais_SamuraiId",
                table: "BattleLogs",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
