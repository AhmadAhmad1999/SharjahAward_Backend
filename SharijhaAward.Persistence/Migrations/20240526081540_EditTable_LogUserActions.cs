using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_LogUserActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HttpMethod",
                table: "LogUserActions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8667), new DateTime(2024, 6, 5, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8682), new DateTime(2024, 5, 31, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8701), new DateTime(2024, 6, 10, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8704), new DateTime(2024, 6, 5, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8708), new DateTime(2024, 6, 15, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8712), new DateTime(2024, 6, 10, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 6, 20, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8717), new DateTime(2024, 6, 15, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8721), new DateTime(2024, 6, 25, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 6, 20, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9633), new DateTime(2024, 5, 26, 11, 15, 35, 405, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 5, 26, 11, 15, 35, 405, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(48), new DateTime(2024, 5, 26, 11, 15, 35, 406, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(55), new DateTime(2024, 5, 26, 11, 15, 35, 406, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 5, 31, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8151), new DateTime(2024, 5, 28, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8172), new DateTime(2024, 5, 29, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8177), new DateTime(2024, 6, 3, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8180), new DateTime(2024, 5, 31, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8182), new DateTime(2024, 6, 1, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9128), new DateTime(2024, 6, 5, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9134), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9495), new DateTime(2024, 6, 15, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9499), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9326));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HttpMethod",
                table: "LogUserActions");

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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(9950), new DateTime(2024, 6, 2, 7, 2, 6, 498, DateTimeKind.Utc).AddTicks(9965), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(328), new DateTime(2024, 6, 12, 7, 2, 6, 499, DateTimeKind.Utc).AddTicks(334), "Wednesday" });

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
    }
}
