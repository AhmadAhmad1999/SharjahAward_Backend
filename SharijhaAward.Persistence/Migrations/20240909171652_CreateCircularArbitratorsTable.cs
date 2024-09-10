using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateCircularArbitratorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "CircularArbitrators",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   CircularId = table.Column<int>(type: "int", nullable: false),
                   ArbitratorId = table.Column<int>(type: "int", nullable: false),
                   CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                   LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                   isDeleted = table.Column<bool>(type: "bit", nullable: false),
                   DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_CircularArbitrators", x => x.Id);
                   table.ForeignKey(
                       name: "FK_CircularArbitrators_Arbitrators_ArbitratorId",
                       column: x => x.ArbitratorId,
                       principalTable: "Arbitrators",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
                   table.ForeignKey(
                       name: "FK_CircularArbitrators_Circulars_CircularId",
                       column: x => x.CircularId,
                       principalTable: "Circulars",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CircularArbitrators");
        }
    }
}
