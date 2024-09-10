using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateCircularsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Circulars",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   CircularText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   IsRead = table.Column<bool>(type: "bit", nullable: false),
                   CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                   LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                   isDeleted = table.Column<bool>(type: "bit", nullable: false),
                   DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Circulars", x => x.Id);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circulars");
        }
    }
}
