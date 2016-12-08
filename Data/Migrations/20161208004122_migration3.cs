using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace explorer_api.Data.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JournalFiles_AspNetUsers_UserId1",
                table: "JournalFiles");

            migrationBuilder.DropIndex(
                name: "IX_JournalFiles_UserId1",
                table: "JournalFiles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "JournalFiles");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "JournalFiles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JournalFiles_UserId",
                table: "JournalFiles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JournalFiles_AspNetUsers_UserId",
                table: "JournalFiles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JournalFiles_AspNetUsers_UserId",
                table: "JournalFiles");

            migrationBuilder.DropIndex(
                name: "IX_JournalFiles_UserId",
                table: "JournalFiles");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "JournalFiles",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "JournalFiles",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_JournalFiles_UserId1",
                table: "JournalFiles",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_JournalFiles_AspNetUsers_UserId1",
                table: "JournalFiles",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
