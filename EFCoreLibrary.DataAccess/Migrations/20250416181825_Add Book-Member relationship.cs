﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreLibrary.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddBookMemberrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_MemberId",
                table: "Books",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Members_MemberId",
                table: "Books",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Members_MemberId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_MemberId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Books");
        }
    }
}
