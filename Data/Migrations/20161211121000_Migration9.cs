using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace explorer_api.Data.Migrations
{
    public partial class Migration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StarSystems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGeneratedOnAdd", true),
                    Allegiance = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Economy = table.Column<string>(nullable: true),
                    ExpeditionId = table.Column<int>(nullable: false),
                    FuelUsed = table.Column<double>(nullable: false),
                    FuleUsed = table.Column<double>(nullable: false),
                    Government = table.Column<string>(nullable: true),
                    JumpDistance = table.Column<double>(nullable: false),
                    Security = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: false),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false),
                    Z = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StarSystems_Expeditions_ExpeditionId",
                        column: x => x.ExpeditionId,
                        principalTable: "Expeditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_ExpeditionId",
                table: "StarSystems",
                column: "ExpeditionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StarSystems");
        }
    }
}
