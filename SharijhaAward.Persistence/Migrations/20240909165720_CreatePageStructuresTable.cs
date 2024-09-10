using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreatePageStructuresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "PageStructures",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   hasHelography = table.Column<bool>(type: "bit", nullable: false),
                   IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   EnglishTitle = table.Column<string>(type: "nvarchar(450)", nullable: false),
                   ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   EnglishSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   ArabicSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   EnglishContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   ArabicContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Slug = table.Column<string>(type: "nvarchar(450)", nullable: false),
                   ParentId = table.Column<int>(type: "int", nullable: true),
                   CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                   LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                   isDeleted = table.Column<bool>(type: "bit", nullable: false),
                   DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_PageStructures", x => x.Id);
                   table.ForeignKey(
                       name: "FK_PageStructures_PageStructures_ParentId",
                       column: x => x.ParentId,
                       principalTable: "PageStructures",
                       principalColumn: "Id");
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageStructures");
        }
    }
}
