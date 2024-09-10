using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryClassification = table.Column<int>(type: "int", nullable: true),
                    FinalArbitrationQualificationMark = table.Column<float>(type: "real", nullable: true),
                    ExpectedNumberOfWinners = table.Column<int>(type: "int", nullable: true),
                    MinimumAmountToObtainAStatement = table.Column<int>(type: "int", nullable: true),
                    MaximumAmountToObtainAStatement = table.Column<int>(type: "int", nullable: true),
                    MinimumRequirementToObtainACertificate = table.Column<int>(type: "int", nullable: true),
                    MaximumRequirementToObtainACertificate = table.Column<int>(type: "int", nullable: true),
                    MinimumWinningScore = table.Column<int>(type: "int", nullable: true),
                    RelatedToClasses = table.Column<bool>(type: "bit", nullable: true),
                    RelatedToEducationalEntities = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Categories_Cycles_CycleId",
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
                name: "Categories");
        }
    }
}
