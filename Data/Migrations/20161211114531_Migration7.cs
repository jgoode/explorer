using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace explorer_api.Data.Migrations
{
    public partial class Migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expeditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGeneratedOnAdd", true),
                    BaseCredits = table.Column<double>(nullable: false),
                    BonusCredits = table.Column<double>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Jumps = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    TotalCredits = table.Column<double>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expeditions", x => x.Id);
                });

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "JournalFiles",
                nullable: false);

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_FileName",
                table: "JournalFiles",
                column: "FileName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_FileName",
                table: "JournalFiles");

            migrationBuilder.DropTable(
                name: "Expeditions");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "JournalFiles",
                nullable: true);
        }
    }
}
