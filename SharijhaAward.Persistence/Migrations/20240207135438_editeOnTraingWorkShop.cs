using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnTraingWorkShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "TrainingWorkshop",
                newName: "TypeOfAttachment");

            migrationBuilder.AddColumn<string>(
                name: "ArabicDescription",
                table: "TrainingWorkshop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "TrainingWorkshop",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "EnglishDescription",
                table: "TrainingWorkshop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Thumbnale",
                table: "TrainingWorkshop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshop_CategoryId",
                table: "TrainingWorkshop",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingWorkshop_Categories_CategoryId",
                table: "TrainingWorkshop",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshop_Categories_CategoryId",
                table: "TrainingWorkshop");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWorkshop_CategoryId",
                table: "TrainingWorkshop");

            migrationBuilder.DropColumn(
                name: "ArabicDescription",
                table: "TrainingWorkshop");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "TrainingWorkshop");

            migrationBuilder.DropColumn(
                name: "EnglishDescription",
                table: "TrainingWorkshop");

            migrationBuilder.DropColumn(
                name: "Thumbnale",
                table: "TrainingWorkshop");

            migrationBuilder.RenameColumn(
                name: "TypeOfAttachment",
                table: "TrainingWorkshop",
                newName: "Icon");
        }
    }
}
