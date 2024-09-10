using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateAgendasTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Agendas",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                   StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   CurrentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   Status = table.Column<int>(type: "int", nullable: false),
                   DateType = table.Column<int>(type: "int", nullable: false),
                   CycleId = table.Column<int>(type: "int", nullable: false),
                   CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                   LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                   isDeleted = table.Column<bool>(type: "bit", nullable: false),
                   DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Agendas", x => x.Id);
                   table.ForeignKey(
                       name: "FK_Agendas_Cycles_CycleId",
                       column: x => x.CycleId,
                       principalTable: "Cycles",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");
        }
    }
}
