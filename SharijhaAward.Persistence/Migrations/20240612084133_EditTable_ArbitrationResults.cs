using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_ArbitrationResults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfObtainingTheCertificate",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfObtainingTheStatement",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WinningDate",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9019), new DateTime(2024, 6, 22, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9029), new DateTime(2024, 6, 17, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9048), new DateTime(2024, 6, 27, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9050), new DateTime(2024, 6, 22, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9053), new DateTime(2024, 7, 2, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9058), new DateTime(2024, 6, 27, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9061), new DateTime(2024, 7, 7, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9063), new DateTime(2024, 7, 2, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9066), new DateTime(2024, 7, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9067), new DateTime(2024, 7, 7, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegistrationPortalClosingDate", "RegistrationPortalOpeningDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1499), new DateTime(2030, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9656), new DateTime(2024, 6, 12, 11, 41, 28, 380, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9778), new DateTime(2024, 6, 12, 11, 41, 28, 380, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 6, 12, 11, 41, 28, 380, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9799), new DateTime(2024, 6, 12, 11, 41, 28, 380, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(5408), new DateTime(2024, 6, 17, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(5413), new DateTime(2024, 6, 14, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(5431), new DateTime(2024, 6, 15, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(5435), new DateTime(2024, 6, 20, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(5438), new DateTime(2024, 6, 17, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(5441), new DateTime(2024, 6, 18, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(6664), new DateTime(2024, 6, 22, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7050), new DateTime(2024, 7, 2, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 378, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 381, DateTimeKind.Utc).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 8, 41, 28, 380, DateTimeKind.Utc).AddTicks(9422));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfObtainingTheCertificate",
                table: "ArbitrationResults");

            migrationBuilder.DropColumn(
                name: "DateOfObtainingTheStatement",
                table: "ArbitrationResults");

            migrationBuilder.DropColumn(
                name: "WinningDate",
                table: "ArbitrationResults");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5135), new DateTime(2024, 6, 22, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5148), new DateTime(2024, 6, 17, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5169), new DateTime(2024, 6, 27, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5171), new DateTime(2024, 6, 22, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5174), new DateTime(2024, 7, 2, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5177), new DateTime(2024, 6, 27, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5181), new DateTime(2024, 7, 7, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5183), new DateTime(2024, 7, 2, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5187), new DateTime(2024, 7, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5191), new DateTime(2024, 7, 7, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RegistrationPortalClosingDate", "RegistrationPortalOpeningDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8336), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6002), new DateTime(2024, 6, 12, 9, 41, 6, 388, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6138), new DateTime(2024, 6, 12, 9, 41, 6, 388, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6155), new DateTime(2024, 6, 12, 9, 41, 6, 388, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6164), new DateTime(2024, 6, 12, 9, 41, 6, 388, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6775), new DateTime(2024, 6, 17, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6783), new DateTime(2024, 6, 14, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 6, 15, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 6, 20, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6807), new DateTime(2024, 6, 17, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6811), new DateTime(2024, 6, 18, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(7961), new DateTime(2024, 6, 22, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8232), new DateTime(2024, 7, 2, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 386, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 389, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 12, 6, 41, 6, 388, DateTimeKind.Utc).AddTicks(5607));
        }
    }
}
