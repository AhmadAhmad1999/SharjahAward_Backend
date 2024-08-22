using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_Arbitrations_FinalArbitrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoneArbitrationUserId",
                table: "FinalArbitrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoneArbitrationUserId",
                table: "Arbitrations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 8, 28, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9761), new DateTime(2024, 9, 1, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9759), new DateTime(2024, 8, 27, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9762), new DateTime(2024, 9, 3, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9766), new DateTime(2024, 9, 7, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9764), new DateTime(2024, 9, 2, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9767), new DateTime(2024, 9, 9, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9770), new DateTime(2024, 9, 13, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9768), new DateTime(2024, 9, 8, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9771), new DateTime(2024, 9, 15, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9774), new DateTime(2024, 9, 19, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9772), new DateTime(2024, 9, 14, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9775), new DateTime(2024, 9, 21, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9782), new DateTime(2024, 9, 25, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9776), new DateTime(2024, 9, 20, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4928), new DateTime(2024, 8, 27, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4933), new DateTime(2024, 8, 24, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4944), new DateTime(2024, 8, 25, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4947), new DateTime(2024, 8, 30, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4949), new DateTime(2024, 8, 27, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4950), new DateTime(2024, 8, 28, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5382), new DateTime(2024, 9, 1, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5389), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5417), new DateTime(2024, 9, 11, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(5419), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "create", new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4768), "إضافة مقابلة" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 156, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 22, 11, 43, 58, 155, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.CreateIndex(
                name: "IX_FinalArbitrations_DoneArbitrationUserId",
                table: "FinalArbitrations",
                column: "DoneArbitrationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrations_DoneArbitrationUserId",
                table: "Arbitrations",
                column: "DoneArbitrationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrations_Users_DoneArbitrationUserId",
                table: "Arbitrations",
                column: "DoneArbitrationUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FinalArbitrations_Users_DoneArbitrationUserId",
                table: "FinalArbitrations",
                column: "DoneArbitrationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrations_Users_DoneArbitrationUserId",
                table: "Arbitrations");

            migrationBuilder.DropForeignKey(
                name: "FK_FinalArbitrations_Users_DoneArbitrationUserId",
                table: "FinalArbitrations");

            migrationBuilder.DropIndex(
                name: "IX_FinalArbitrations_DoneArbitrationUserId",
                table: "FinalArbitrations");

            migrationBuilder.DropIndex(
                name: "IX_Arbitrations_DoneArbitrationUserId",
                table: "Arbitrations");

            migrationBuilder.DropColumn(
                name: "DoneArbitrationUserId",
                table: "FinalArbitrations");

            migrationBuilder.DropColumn(
                name: "DoneArbitrationUserId",
                table: "Arbitrations");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(496), new DateTime(2024, 8, 24, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(507), new DateTime(2024, 8, 28, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(504), new DateTime(2024, 8, 23, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(508), new DateTime(2024, 8, 30, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(512), new DateTime(2024, 9, 3, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(510), new DateTime(2024, 8, 29, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(513), new DateTime(2024, 9, 5, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(516), new DateTime(2024, 9, 9, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 9, 4, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(517), new DateTime(2024, 9, 11, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(520), new DateTime(2024, 9, 15, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(519), new DateTime(2024, 9, 10, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(521), new DateTime(2024, 9, 17, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(524), new DateTime(2024, 9, 21, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 9, 16, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5401), new DateTime(2024, 8, 23, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5404), new DateTime(2024, 8, 20, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5412), new DateTime(2024, 8, 21, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5414), new DateTime(2024, 8, 26, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5416), new DateTime(2024, 8, 23, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5417), new DateTime(2024, 8, 24, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5901), new DateTime(2024, 8, 28, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5908), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5935), new DateTime(2024, 9, 7, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5937), "Saturday" });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "update", new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5206), "تعديل تدقيق التحكيم" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 380, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 18, 12, 17, 45, 381, DateTimeKind.Utc).AddTicks(733));
        }
    }
}
