using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRelationBetweenCoordinatorAndEduEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationCoordinators");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8425), new DateTime(2024, 7, 15, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8435), new DateTime(2024, 7, 19, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8433), new DateTime(2024, 7, 14, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8437), new DateTime(2024, 7, 21, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 7, 25, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 7, 20, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8442), new DateTime(2024, 7, 27, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8446), new DateTime(2024, 7, 31, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8444), new DateTime(2024, 7, 26, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8447), new DateTime(2024, 8, 2, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8451), new DateTime(2024, 8, 6, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8449), new DateTime(2024, 8, 1, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8452), new DateTime(2024, 8, 8, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8456), new DateTime(2024, 8, 12, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8454), new DateTime(2024, 8, 7, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9174), new DateTime(2024, 7, 14, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9177), new DateTime(2024, 7, 11, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9183), new DateTime(2024, 7, 12, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9186), new DateTime(2024, 7, 17, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9187), new DateTime(2024, 7, 14, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9189), new DateTime(2024, 7, 15, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9833), new DateTime(2024, 7, 19, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9837), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9978), new DateTime(2024, 7, 29, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(9980), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 956, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 958, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 9, 18, 34, 957, DateTimeKind.Utc).AddTicks(8682));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationCoordinators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoordinatorId = table.Column<int>(type: "int", nullable: false),
                    EducationalEntityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationCoordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationCoordinators_Coordinators_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationCoordinators_EducationalEntities_EducationalEntityId",
                        column: x => x.EducationalEntityId,
                        principalTable: "EducationalEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4480), new DateTime(2024, 7, 10, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4489), new DateTime(2024, 7, 14, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4487), new DateTime(2024, 7, 9, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4491), new DateTime(2024, 7, 16, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4494), new DateTime(2024, 7, 20, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4492), new DateTime(2024, 7, 15, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 7, 22, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 7, 26, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4496), new DateTime(2024, 7, 21, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 7, 28, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 8, 1, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4499), new DateTime(2024, 7, 27, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4502), new DateTime(2024, 8, 3, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 8, 7, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4503), new DateTime(2024, 8, 2, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.InsertData(
                table: "EducationCoordinators",
                columns: new[] { "Id", "CoordinatorId", "CreatedAt", "CreatedBy", "DeletedAt", "EducationalEntityId", "LastModifiedAt", "LastModifiedBy", "RelatedDate", "isDeleted" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4752), null, null, 1, null, null, new DateTime(2024, 7, 4, 16, 8, 12, 718, DateTimeKind.Local).AddTicks(4757), false },
                    { 2, 11, new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4771), null, null, 1, null, null, new DateTime(2024, 7, 4, 16, 8, 12, 718, DateTimeKind.Local).AddTicks(4772), false },
                    { 3, 12, new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4773), null, null, 2, null, null, new DateTime(2024, 7, 4, 16, 8, 12, 718, DateTimeKind.Local).AddTicks(4774), false },
                    { 4, 13, new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4775), null, null, 2, null, null, new DateTime(2024, 7, 4, 16, 8, 12, 718, DateTimeKind.Local).AddTicks(4776), false }
                });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9975), new DateTime(2024, 7, 9, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9978), new DateTime(2024, 7, 6, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9986), new DateTime(2024, 7, 7, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 7, 12, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 7, 9, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9990), new DateTime(2024, 7, 10, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(370), new DateTime(2024, 7, 14, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(374), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(410), new DateTime(2024, 7, 24, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(412), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.CreateIndex(
                name: "IX_EducationCoordinators_CoordinatorId",
                table: "EducationCoordinators",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationCoordinators_EducationalEntityId",
                table: "EducationCoordinators",
                column: "EducationalEntityId");
        }
    }
}
