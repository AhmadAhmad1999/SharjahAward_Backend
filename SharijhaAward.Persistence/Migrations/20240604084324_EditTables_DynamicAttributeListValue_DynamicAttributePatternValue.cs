using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_DynamicAttributeListValue_DynamicAttributePatternValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "DynamicAttributePatternValues",
                newName: "EnglishValue");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "DynamicAttributeListValues",
                newName: "EnglishValue");

            migrationBuilder.AddColumn<string>(
                name: "ArabicValue",
                table: "DynamicAttributePatternValues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicValue",
                table: "DynamicAttributeListValues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7254), new DateTime(2024, 6, 14, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7267), new DateTime(2024, 6, 9, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7287), new DateTime(2024, 6, 19, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7290), new DateTime(2024, 6, 14, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7295), new DateTime(2024, 6, 24, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7298), new DateTime(2024, 6, 19, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7303), new DateTime(2024, 6, 29, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 6, 24, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7312), new DateTime(2024, 7, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7316), new DateTime(2024, 6, 29, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicValue", "CreatedAt" },
                values: new object[] { "Test Value 1", new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArabicValue", "CreatedAt" },
                values: new object[] { "Test Value 2", new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArabicValue", "CreatedAt" },
                values: new object[] { "Test Value 3", new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArabicValue", "CreatedAt" },
                values: new object[] { "Test Value 4", new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArabicValue", "CreatedAt" },
                values: new object[] { "Test Value 5", new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8356), new DateTime(2024, 6, 4, 11, 43, 18, 725, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8521), new DateTime(2024, 6, 4, 11, 43, 18, 725, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8554), new DateTime(2024, 6, 4, 11, 43, 18, 725, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8569), new DateTime(2024, 6, 4, 11, 43, 18, 725, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9918), new DateTime(2024, 6, 9, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9926), new DateTime(2024, 6, 6, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9951), new DateTime(2024, 6, 7, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9959), new DateTime(2024, 6, 12, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9964), new DateTime(2024, 6, 9, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9967), new DateTime(2024, 6, 10, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(1577), new DateTime(2024, 6, 14, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(1587), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 6, 24, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(1929), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7921));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicValue",
                table: "DynamicAttributePatternValues");

            migrationBuilder.DropColumn(
                name: "ArabicValue",
                table: "DynamicAttributeListValues");

            migrationBuilder.RenameColumn(
                name: "EnglishValue",
                table: "DynamicAttributePatternValues",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "EnglishValue",
                table: "DynamicAttributeListValues",
                newName: "Value");

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
        }
    }
}
