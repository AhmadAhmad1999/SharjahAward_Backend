using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateStaticAttributesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaticAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttributeDataTypeId = table.Column<int>(type: "int", nullable: false),
                    AttributeTableNameId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaticAttributes_AttributeDataTypes_AttributeDataTypeId",
                        column: x => x.AttributeDataTypeId,
                        principalTable: "AttributeDataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaticAttributes_AttributeTableNames_AttributeTableNameId",
                        column: x => x.AttributeTableNameId,
                        principalTable: "AttributeTableNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                 name: "StaticAttributes");
        }
    }
}
