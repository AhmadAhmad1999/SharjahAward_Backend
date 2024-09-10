using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateGeneralWorkshopsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralWorkshops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfWorkShop = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgendaImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralWorkshops", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralWorkshops");
        }
    }
}
