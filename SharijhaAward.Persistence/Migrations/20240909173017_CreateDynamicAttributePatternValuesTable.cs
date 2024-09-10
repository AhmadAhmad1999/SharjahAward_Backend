﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateDynamicAttributePatternValuesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "DynamicAttributePatternValues",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   ArabicValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   EnglishValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   DynamicAttributePatternId = table.Column<int>(type: "int", nullable: false),
                   CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                   LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                   isDeleted = table.Column<bool>(type: "bit", nullable: false),
                   DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_DynamicAttributePatternValues", x => x.Id);
                   table.ForeignKey(
                       name: "FK_DynamicAttributePatternValues_DynamicAttributePatterns_DynamicAttributePatternId",
                       column: x => x.DynamicAttributePatternId,
                       principalTable: "DynamicAttributePatterns",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DynamicAttributePatternValues");
        }
    }
}
