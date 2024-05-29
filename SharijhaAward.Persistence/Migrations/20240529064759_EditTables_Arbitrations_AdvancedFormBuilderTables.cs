using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_Arbitrations_AdvancedFormBuilderTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedFormBuilderSections_VirtualTableForSections_VirtualTableForSectioniD",
                table: "AdvancedFormBuilderSections");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedFormBuilderTableValues_VirtualTables_RecordId",
                table: "AdvancedFormBuilderTableValues");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedFormBuilderValues_VirtualTables_RecordId",
                table: "AdvancedFormBuilderValues");

            migrationBuilder.DropColumn(
                name: "IsRejectedFromArbitrationAuditStep",
                table: "Arbitrations");

            migrationBuilder.RenameColumn(
                name: "RecordId",
                table: "AdvancedFormBuilderValues",
                newName: "VirtualTableId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedFormBuilderValues_RecordId",
                table: "AdvancedFormBuilderValues",
                newName: "IX_AdvancedFormBuilderValues_VirtualTableId");

            migrationBuilder.RenameColumn(
                name: "RecordId",
                table: "AdvancedFormBuilderTableValues",
                newName: "VirtualTableId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedFormBuilderTableValues_RecordId",
                table: "AdvancedFormBuilderTableValues",
                newName: "IX_AdvancedFormBuilderTableValues_VirtualTableId");

            migrationBuilder.RenameColumn(
                name: "VirtualTableForSectioniD",
                table: "AdvancedFormBuilderSections",
                newName: "VirtualTableForSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedFormBuilderSections_VirtualTableForSectioniD",
                table: "AdvancedFormBuilderSections",
                newName: "IX_AdvancedFormBuilderSections_VirtualTableForSectionId");

            migrationBuilder.AddColumn<string>(
                name: "ArabicTitle",
                table: "VirtualTableForSections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishTitle",
                table: "VirtualTableForSections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderGeneralValidations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvancedFormBuilderId = table.Column<int>(type: "int", nullable: false),
                    AttributeOperationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderGeneralValidations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderGeneralValidations_AdvancedFormBuilders_AdvancedFormBuilderId",
                        column: x => x.AdvancedFormBuilderId,
                        principalTable: "AdvancedFormBuilders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderGeneralValidations_AttributeOperations_AttributeOperationId",
                        column: x => x.AttributeOperationId,
                        principalTable: "AttributeOperations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(291), new DateTime(2024, 6, 8, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(303), new DateTime(2024, 6, 3, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(320), new DateTime(2024, 6, 13, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(322), new DateTime(2024, 6, 8, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(325), new DateTime(2024, 6, 18, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(327), new DateTime(2024, 6, 13, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(331), new DateTime(2024, 6, 23, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(333), new DateTime(2024, 6, 18, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(335), new DateTime(2024, 6, 28, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(337), new DateTime(2024, 6, 23, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1004), new DateTime(2024, 5, 29, 9, 47, 55, 211, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1133), new DateTime(2024, 5, 29, 9, 47, 55, 211, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1149), new DateTime(2024, 5, 29, 9, 47, 55, 211, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1155), new DateTime(2024, 5, 29, 9, 47, 55, 211, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8837), new DateTime(2024, 6, 3, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8842), new DateTime(2024, 5, 31, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8857), new DateTime(2024, 6, 1, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8863), new DateTime(2024, 6, 6, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8865), new DateTime(2024, 6, 3, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8867), new DateTime(2024, 6, 4, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(9819), new DateTime(2024, 6, 8, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(9826), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(80), new DateTime(2024, 6, 18, 6, 47, 55, 209, DateTimeKind.Utc).AddTicks(84), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 208, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 6, 47, 55, 211, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderGeneralValidations_AdvancedFormBuilderId",
                table: "AdvancedFormBuilderGeneralValidations",
                column: "AdvancedFormBuilderId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderGeneralValidations_AttributeOperationId",
                table: "AdvancedFormBuilderGeneralValidations",
                column: "AttributeOperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedFormBuilderSections_VirtualTableForSections_VirtualTableForSectionId",
                table: "AdvancedFormBuilderSections",
                column: "VirtualTableForSectionId",
                principalTable: "VirtualTableForSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedFormBuilderTableValues_VirtualTables_VirtualTableId",
                table: "AdvancedFormBuilderTableValues",
                column: "VirtualTableId",
                principalTable: "VirtualTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedFormBuilderValues_VirtualTables_VirtualTableId",
                table: "AdvancedFormBuilderValues",
                column: "VirtualTableId",
                principalTable: "VirtualTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedFormBuilderSections_VirtualTableForSections_VirtualTableForSectionId",
                table: "AdvancedFormBuilderSections");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedFormBuilderTableValues_VirtualTables_VirtualTableId",
                table: "AdvancedFormBuilderTableValues");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedFormBuilderValues_VirtualTables_VirtualTableId",
                table: "AdvancedFormBuilderValues");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderGeneralValidations");

            migrationBuilder.DropColumn(
                name: "ArabicTitle",
                table: "VirtualTableForSections");

            migrationBuilder.DropColumn(
                name: "EnglishTitle",
                table: "VirtualTableForSections");

            migrationBuilder.RenameColumn(
                name: "VirtualTableId",
                table: "AdvancedFormBuilderValues",
                newName: "RecordId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedFormBuilderValues_VirtualTableId",
                table: "AdvancedFormBuilderValues",
                newName: "IX_AdvancedFormBuilderValues_RecordId");

            migrationBuilder.RenameColumn(
                name: "VirtualTableId",
                table: "AdvancedFormBuilderTableValues",
                newName: "RecordId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedFormBuilderTableValues_VirtualTableId",
                table: "AdvancedFormBuilderTableValues",
                newName: "IX_AdvancedFormBuilderTableValues_RecordId");

            migrationBuilder.RenameColumn(
                name: "VirtualTableForSectionId",
                table: "AdvancedFormBuilderSections",
                newName: "VirtualTableForSectioniD");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedFormBuilderSections_VirtualTableForSectionId",
                table: "AdvancedFormBuilderSections",
                newName: "IX_AdvancedFormBuilderSections_VirtualTableForSectioniD");

            migrationBuilder.AddColumn<bool>(
                name: "IsRejectedFromArbitrationAuditStep",
                table: "Arbitrations",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3516), new DateTime(2024, 6, 6, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3519), new DateTime(2024, 6, 1, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3524), new DateTime(2024, 6, 11, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3526), new DateTime(2024, 6, 6, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3528), new DateTime(2024, 6, 16, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3529), new DateTime(2024, 6, 11, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3532), new DateTime(2024, 6, 21, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3534), new DateTime(2024, 6, 16, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3536), new DateTime(2024, 6, 26, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3537), new DateTime(2024, 6, 21, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3817), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3843), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3845), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5772), new DateTime(2024, 6, 1, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5775), new DateTime(2024, 5, 29, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5782), new DateTime(2024, 5, 30, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5784), new DateTime(2024, 6, 4, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5786), new DateTime(2024, 6, 1, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5787), new DateTime(2024, 6, 2, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6195), new DateTime(2024, 6, 6, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6199), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6334), new DateTime(2024, 6, 16, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6335), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedFormBuilderSections_VirtualTableForSections_VirtualTableForSectioniD",
                table: "AdvancedFormBuilderSections",
                column: "VirtualTableForSectioniD",
                principalTable: "VirtualTableForSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedFormBuilderTableValues_VirtualTables_RecordId",
                table: "AdvancedFormBuilderTableValues",
                column: "RecordId",
                principalTable: "VirtualTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedFormBuilderValues_VirtualTables_RecordId",
                table: "AdvancedFormBuilderValues",
                column: "RecordId",
                principalTable: "VirtualTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
