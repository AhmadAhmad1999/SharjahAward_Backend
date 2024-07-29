using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addActionToPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9510), new DateTime(2024, 8, 4, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9520), new DateTime(2024, 8, 8, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9519), new DateTime(2024, 8, 3, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9522), new DateTime(2024, 8, 10, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9526), new DateTime(2024, 8, 14, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9524), new DateTime(2024, 8, 9, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9527), new DateTime(2024, 8, 16, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9530), new DateTime(2024, 8, 20, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9529), new DateTime(2024, 8, 15, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9532), new DateTime(2024, 8, 22, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9535), new DateTime(2024, 8, 26, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9534), new DateTime(2024, 8, 21, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9537), new DateTime(2024, 8, 28, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9540), new DateTime(2024, 9, 1, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9538), new DateTime(2024, 8, 27, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9631), new DateTime(2024, 8, 3, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9636), new DateTime(2024, 7, 31, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9646), new DateTime(2024, 8, 1, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9648), new DateTime(2024, 8, 6, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9650), new DateTime(2024, 8, 3, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9651), new DateTime(2024, 8, 4, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(130), new DateTime(2024, 8, 8, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(134), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(280), new DateTime(2024, 8, 18, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(282), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.InsertData(
                table: "OnePageText",
                columns: new[] { "Id", "ArabicText", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishText", "LastModifiedAt", "LastModifiedBy", "Slug", "Type", "isDeleted" },
                values: new object[] { 5, "", new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1550), null, null, "", null, null, "About_Application", 2, false });

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9776));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Action",
                table: "Permissions");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2524), new DateTime(2024, 7, 31, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2534), new DateTime(2024, 8, 4, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2533), new DateTime(2024, 7, 30, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2536), new DateTime(2024, 8, 6, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2539), new DateTime(2024, 8, 10, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2537), new DateTime(2024, 8, 5, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 8, 12, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 8, 16, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2541), new DateTime(2024, 8, 11, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2544), new DateTime(2024, 8, 18, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2547), new DateTime(2024, 8, 22, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2545), new DateTime(2024, 8, 17, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2548), new DateTime(2024, 8, 24, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 8, 28, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2549), new DateTime(2024, 8, 23, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7660), new DateTime(2024, 7, 30, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7664), new DateTime(2024, 7, 27, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7672), new DateTime(2024, 7, 28, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7676), new DateTime(2024, 8, 2, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7677), new DateTime(2024, 7, 30, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7679), new DateTime(2024, 7, 31, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8075), new DateTime(2024, 8, 4, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8081), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8122), new DateTime(2024, 8, 14, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8124), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2730));
        }
    }
}
