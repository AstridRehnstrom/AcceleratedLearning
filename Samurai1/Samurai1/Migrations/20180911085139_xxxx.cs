﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Samurai1.Migrations
{
    public partial class xxxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BattleEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Summary = table.Column<string>(nullable: true),
                    BattleLogId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BattleEvents_BattleLogs_BattleLogId",
                        column: x => x.BattleLogId,
                        principalTable: "BattleLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BattleEvents_BattleLogId",
                table: "BattleEvents",
                column: "BattleLogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BattleEvents");
        }
    }
}
