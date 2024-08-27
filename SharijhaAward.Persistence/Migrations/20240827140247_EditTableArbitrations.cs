using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTableArbitrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedByUserId",
                table: "Arbitrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SortedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrations_AssignedByUserId",
                table: "Arbitrations",
                column: "AssignedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrations_Users_AssignedByUserId",
                table: "Arbitrations",
                column: "AssignedByUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrations_Users_AssignedByUserId",
                table: "Arbitrations");

            migrationBuilder.DropIndex(
                name: "IX_Arbitrations_AssignedByUserId",
                table: "Arbitrations");

            migrationBuilder.DropColumn(
                name: "AssignedByUserId",
                table: "Arbitrations");

            migrationBuilder.DropColumn(
                name: "SortedAt",
                table: "Arbitrations");
        }
    }
}
