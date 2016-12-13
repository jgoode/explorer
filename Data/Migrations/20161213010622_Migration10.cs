using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace explorer_api.Data.Migrations
{
    public partial class Migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SystemObjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGeneratedOnAdd", true),
                    AbsMagnitude = table.Column<double>(nullable: false),
                    AgeMy = table.Column<double>(nullable: false),
                    Atmosphere = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    Eccentricity = table.Column<double>(nullable: false),
                    Landable = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrbitalPeriod = table.Column<double>(nullable: false),
                    OribitalInclination = table.Column<double>(nullable: false),
                    Periapsis = table.Column<double>(nullable: false),
                    PlanetClass = table.Column<string>(nullable: true),
                    Radius = table.Column<double>(nullable: false),
                    RotationalPeriod = table.Column<double>(nullable: false),
                    SemiMajorAxis = table.Column<double>(nullable: false),
                    StarSystemId = table.Column<int>(nullable: false),
                    StarType = table.Column<string>(nullable: true),
                    SurfaceGravity = table.Column<double>(nullable: false),
                    SurfacePressure = table.Column<double>(nullable: false),
                    SurfaceTemp = table.Column<double>(nullable: false),
                    TerraformState = table.Column<string>(nullable: true),
                    TidalLock = table.Column<int>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Volcanism = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemObjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemObjects_StarSystems_StarSystemId",
                        column: x => x.StarSystemId,
                        principalTable: "StarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SystemObjects_StarSystemId",
                table: "SystemObjects",
                column: "StarSystemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "StarSystems");

            migrationBuilder.DropTable(
                name: "SystemObjects");
        }
    }
}
