using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_DynamicAttributeSection_AddTable_DynamicAttributeTableValue2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8111), new DateTime(2024, 6, 2, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8121), new DateTime(2024, 5, 28, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8153), new DateTime(2024, 6, 7, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8158), new DateTime(2024, 6, 2, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8165), new DateTime(2024, 6, 12, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8169), new DateTime(2024, 6, 7, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8175), new DateTime(2024, 6, 17, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8179), new DateTime(2024, 6, 12, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8185), new DateTime(2024, 6, 22, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8190), new DateTime(2024, 6, 17, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9716), new DateTime(2024, 5, 23, 10, 2, 6, 502, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9886), new DateTime(2024, 5, 23, 10, 2, 6, 502, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 5, 23, 10, 2, 6, 502, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9936), new DateTime(2024, 5, 23, 10, 2, 6, 502, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7374), new DateTime(2024, 5, 28, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7382), new DateTime(2024, 5, 25, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7407), new DateTime(2024, 5, 26, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7415), new DateTime(2024, 5, 31, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 5, 28, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7424), new DateTime(2024, 5, 29, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(9950), new DateTime(2024, 6, 2, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(328), new DateTime(2024, 6, 12, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 503, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 7, 2, 6, 502, DateTimeKind.Utc).AddTicks(9181));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 6, 2, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7856), new DateTime(2024, 5, 28, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7879), new DateTime(2024, 6, 7, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7884), new DateTime(2024, 6, 2, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 6, 12, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7892), new DateTime(2024, 6, 7, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7897), new DateTime(2024, 6, 17, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 6, 12, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7905), new DateTime(2024, 6, 22, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7908), new DateTime(2024, 6, 17, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9070), new DateTime(2024, 5, 23, 9, 53, 44, 679, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 5, 23, 9, 53, 44, 679, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9239), new DateTime(2024, 5, 23, 9, 53, 44, 679, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9266), new DateTime(2024, 5, 23, 9, 53, 44, 679, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7979), new DateTime(2024, 5, 28, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7985), new DateTime(2024, 5, 25, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8004), new DateTime(2024, 5, 26, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 5, 31, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 5, 28, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8019), new DateTime(2024, 5, 29, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(9859), new DateTime(2024, 6, 2, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(172), new DateTime(2024, 6, 12, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8595));
        }
    }
}
