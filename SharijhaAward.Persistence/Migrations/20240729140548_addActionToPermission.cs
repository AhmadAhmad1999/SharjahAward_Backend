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
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(352), new DateTime(2024, 8, 4, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(369), new DateTime(2024, 8, 8, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(368), new DateTime(2024, 8, 3, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(371), new DateTime(2024, 8, 10, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(374), new DateTime(2024, 8, 14, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(373), new DateTime(2024, 8, 9, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(376), new DateTime(2024, 8, 16, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(379), new DateTime(2024, 8, 20, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(378), new DateTime(2024, 8, 15, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(381), new DateTime(2024, 8, 22, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(384), new DateTime(2024, 8, 26, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(382), new DateTime(2024, 8, 21, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(386), new DateTime(2024, 8, 28, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(389), new DateTime(2024, 9, 1, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(387), new DateTime(2024, 8, 27, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 412, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9012), new DateTime(2024, 8, 3, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9015), new DateTime(2024, 7, 31, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9023), new DateTime(2024, 8, 1, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9027), new DateTime(2024, 8, 6, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9029), new DateTime(2024, 8, 3, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9030), new DateTime(2024, 8, 4, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9595), new DateTime(2024, 8, 8, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9821), new DateTime(2024, 8, 18, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "create", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "read", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "update", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Action", "CreatedAt" },
                values: new object[] { "delete", new DateTime(2024, 7, 29, 14, 5, 39, 411, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 5, 39, 413, DateTimeKind.Utc).AddTicks(639));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "Permissions");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5946), new DateTime(2024, 8, 4, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5963), new DateTime(2024, 8, 8, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 8, 3, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 8, 10, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5972), new DateTime(2024, 8, 14, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 8, 9, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5977), new DateTime(2024, 8, 16, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 8, 20, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5978), new DateTime(2024, 8, 15, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5982), new DateTime(2024, 8, 22, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5985), new DateTime(2024, 8, 26, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5983), new DateTime(2024, 8, 21, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5986), new DateTime(2024, 8, 28, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5991), new DateTime(2024, 9, 1, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5988), new DateTime(2024, 8, 27, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2662), new DateTime(2024, 8, 3, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2666), new DateTime(2024, 7, 31, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2674), new DateTime(2024, 8, 1, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2677), new DateTime(2024, 8, 6, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2680), new DateTime(2024, 8, 3, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2681), new DateTime(2024, 8, 4, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3337), new DateTime(2024, 8, 8, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3534), new DateTime(2024, 8, 18, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 298, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 12, 36, 7, 299, DateTimeKind.Utc).AddTicks(6429));
        }
    }
}
