using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateAwardSponsorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AwardSponsors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishUpbringingAndAiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicUpbringingAndAiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishHonoraryPositions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicHonoraryPositions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishEducationalStages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicEducationalStages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishWritings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicWritings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardSponsors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                 name: "AwardSponsors");
        }
    }
}
