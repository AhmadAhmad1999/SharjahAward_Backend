using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateEducationalInstitutionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "EducationalInstitutions",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   EducationType = table.Column<int>(type: "int", nullable: false),
                   Emirates = table.Column<int>(type: "int", nullable: false),
                   EducationalEntityId = table.Column<int>(type: "int", nullable: false),
                   CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                   LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                   isDeleted = table.Column<bool>(type: "bit", nullable: false),
                   DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_EducationalInstitutions", x => x.Id);
                   table.ForeignKey(
                       name: "FK_EducationalInstitutions_EducationalEntities_EducationalEntityId",
                       column: x => x.EducationalEntityId,
                       principalTable: "EducationalEntities",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationalInstitutions");
        }
    }
}
