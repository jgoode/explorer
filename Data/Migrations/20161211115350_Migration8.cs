using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace explorer_api.Data.Migrations
{
    public partial class Migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Expeditions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Expeditions",
                nullable: false);
        }
    }
}
