using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddOurGoulTilte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageCards_PageStructures_PageStructureId",
                table: "ImageCards");

            migrationBuilder.DropForeignKey(
                name: "FK_PageStructureImages_ImageCards_ImageId",
                table: "PageStructureImages");

            migrationBuilder.DropIndex(
                name: "IX_ImageCards_PageStructureId",
                table: "ImageCards");

            migrationBuilder.DropColumn(
                name: "PageStructureId",
                table: "ImageCards");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "PageStructureImages",
                newName: "ImageCardId");

            migrationBuilder.RenameIndex(
                name: "IX_PageStructureImages_ImageId",
                table: "PageStructureImages",
                newName: "IX_PageStructureImages_ImageCardId");

            migrationBuilder.AddColumn<int>(
                name: "PageId",
                table: "ImageCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ArabicOurGoalTitle",
                table: "AboutAwardPage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishOurGoalTitle",
                table: "AboutAwardPage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicOurGoalTitle", "CreatedAt", "EnglishOurGoalTitle" },
                values: new object[] { "", new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1369), "" });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8806), new DateTime(2024, 7, 10, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 7, 14, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8822), new DateTime(2024, 7, 9, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8825), new DateTime(2024, 7, 16, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8829), new DateTime(2024, 7, 20, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8827), new DateTime(2024, 7, 15, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8831), new DateTime(2024, 7, 22, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8835), new DateTime(2024, 7, 26, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8833), new DateTime(2024, 7, 21, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8837), new DateTime(2024, 7, 28, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8842), new DateTime(2024, 8, 1, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8839), new DateTime(2024, 7, 27, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8844), new DateTime(2024, 8, 3, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8848), new DateTime(2024, 8, 7, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8845), new DateTime(2024, 8, 2, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9352), new DateTime(2024, 7, 4, 11, 0, 36, 75, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9384), new DateTime(2024, 7, 4, 11, 0, 36, 75, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 7, 4, 11, 0, 36, 75, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 7, 4, 11, 0, 36, 75, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1380), new DateTime(2024, 7, 9, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1385), new DateTime(2024, 7, 6, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1394), new DateTime(2024, 7, 7, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1397), new DateTime(2024, 7, 12, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1399), new DateTime(2024, 7, 9, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1401), new DateTime(2024, 7, 10, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2356), new DateTime(2024, 7, 14, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2361), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2562), new DateTime(2024, 7, 24, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2564), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.CreateIndex(
                name: "IX_ImageCards_PageId",
                table: "ImageCards",
                column: "PageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageCards_PageStructures_PageId",
                table: "ImageCards",
                column: "PageId",
                principalTable: "PageStructures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PageStructureImages_ImageCards_ImageCardId",
                table: "PageStructureImages",
                column: "ImageCardId",
                principalTable: "ImageCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageCards_PageStructures_PageId",
                table: "ImageCards");

            migrationBuilder.DropForeignKey(
                name: "FK_PageStructureImages_ImageCards_ImageCardId",
                table: "PageStructureImages");

            migrationBuilder.DropIndex(
                name: "IX_ImageCards_PageId",
                table: "ImageCards");

            migrationBuilder.DropColumn(
                name: "PageId",
                table: "ImageCards");

            migrationBuilder.DropColumn(
                name: "ArabicOurGoalTitle",
                table: "AboutAwardPage");

            migrationBuilder.DropColumn(
                name: "EnglishOurGoalTitle",
                table: "AboutAwardPage");

            migrationBuilder.RenameColumn(
                name: "ImageCardId",
                table: "PageStructureImages",
                newName: "ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_PageStructureImages_ImageCardId",
                table: "PageStructureImages",
                newName: "IX_PageStructureImages_ImageId");

            migrationBuilder.AddColumn<int>(
                name: "PageStructureId",
                table: "ImageCards",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3208), new DateTime(2024, 7, 8, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3217), new DateTime(2024, 7, 12, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3216), new DateTime(2024, 7, 7, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3219), new DateTime(2024, 7, 14, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3223), new DateTime(2024, 7, 18, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3221), new DateTime(2024, 7, 13, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 7, 20, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3227), new DateTime(2024, 7, 24, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3226), new DateTime(2024, 7, 19, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3229), new DateTime(2024, 7, 26, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 7, 30, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3231), new DateTime(2024, 7, 25, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3234), new DateTime(2024, 8, 1, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3237), new DateTime(2024, 8, 5, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3236), new DateTime(2024, 7, 31, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3628), new DateTime(2024, 7, 2, 15, 8, 23, 127, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 7, 2, 15, 8, 23, 127, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3650), new DateTime(2024, 7, 2, 15, 8, 23, 127, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 7, 2, 15, 8, 23, 127, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3207), new DateTime(2024, 7, 7, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3210), new DateTime(2024, 7, 4, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3217), new DateTime(2024, 7, 5, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3221), new DateTime(2024, 7, 10, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3223), new DateTime(2024, 7, 7, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 7, 8, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 7, 12, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3811), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3977), new DateTime(2024, 7, 22, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3979), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 12, 8, 23, 127, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.CreateIndex(
                name: "IX_ImageCards_PageStructureId",
                table: "ImageCards",
                column: "PageStructureId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageCards_PageStructures_PageStructureId",
                table: "ImageCards",
                column: "PageStructureId",
                principalTable: "PageStructures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageStructureImages_ImageCards_ImageId",
                table: "PageStructureImages",
                column: "ImageId",
                principalTable: "ImageCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
