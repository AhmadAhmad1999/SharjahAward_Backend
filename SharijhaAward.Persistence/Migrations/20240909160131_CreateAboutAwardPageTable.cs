using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateAboutAwardPageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "AboutAwardPage",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   IsAboutHidden = table.Column<bool>(type: "bit", nullable: false),
                   ArabicAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   EnglishAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   ArabicAboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   EnglishAboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   AboutImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   IsOurVisionHidden = table.Column<bool>(type: "bit", nullable: false),
                   ArabicOurVisionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   EnglishOurVisionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   ArabicOurVisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   EnglishOurVisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   OurVisionImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   ArabicOurGoalTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   EnglishOurGoalTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   IsGoalsHidden = table.Column<bool>(type: "bit", nullable: false),
                   CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                   LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                   isDeleted = table.Column<bool>(type: "bit", nullable: false),
                   DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_AboutAwardPage", x => x.Id);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutAwardPage");
        }
    }
}
