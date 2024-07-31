using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addSeederToPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8780), new DateTime(2024, 8, 6, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8794), new DateTime(2024, 8, 10, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8793), new DateTime(2024, 8, 5, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8796), new DateTime(2024, 8, 12, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8799), new DateTime(2024, 8, 16, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8797), new DateTime(2024, 8, 11, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8800), new DateTime(2024, 8, 18, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8804), new DateTime(2024, 8, 22, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8802), new DateTime(2024, 8, 17, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8805), new DateTime(2024, 8, 24, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8808), new DateTime(2024, 8, 28, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8807), new DateTime(2024, 8, 23, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8810), new DateTime(2024, 8, 30, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8813), new DateTime(2024, 9, 3, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8811), new DateTime(2024, 8, 29, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8386), new DateTime(2024, 8, 5, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8389), new DateTime(2024, 8, 2, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8401), new DateTime(2024, 8, 3, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8405), new DateTime(2024, 8, 8, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8406), new DateTime(2024, 8, 5, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 8, 6, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9017), new DateTime(2024, 8, 10, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9021), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9204), new DateTime(2024, 8, 20, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(9206), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.InsertData(
                table: "PermissionHeaders",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { 33, "الأسالة الشائعة العامة", new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9942), null, null, "GeneralFAQ", null, null, false },
                    { 34, "الأسالة الشائعة الخاصة بالفئة", new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9944), null, null, "FAQCategory", null, null, false },
                    { 35, "إحصائيات الجائزة", new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9946), null, null, "AwardStatistic", null, null, false },
                    { 36, "شرائح", new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9948), null, null, "Slider", null, null, false }
                });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Action", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "PermissionHeaderId", "isDeleted" },
                values: new object[,]
                {
                    { 50, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8104), null, null, null, null, "عرض التعليمات", 16, false },
                    { 51, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8106), null, null, null, null, "تعديل التعليمات", 16, false },
                    { 52, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8108), null, null, null, null, "إضافة الإجتماعات", 17, false },
                    { 53, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8110), null, null, null, null, "عرض الإجتماعات", 17, false },
                    { 54, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8113), null, null, null, null, "تعديل الإجتماعات", 17, false },
                    { 55, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8115), null, null, null, null, "حذف الإجتماعات", 17, false },
                    { 56, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8117), null, null, null, null, "إضافة الأخبار", 18, false },
                    { 57, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8119), null, null, null, null, "عرض الأخبار", 18, false },
                    { 58, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8121), null, null, null, null, "تعديل الأخبار", 18, false },
                    { 59, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8123), null, null, null, null, "حذف الأخبار", 18, false },
                    { 60, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8125), null, null, null, null, "إضافة الإشعارات", 19, false },
                    { 61, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8127), null, null, null, null, "عرض الإشعارات", 19, false },
                    { 62, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8129), null, null, null, null, "تعديل الإشعارات", 19, false },
                    { 63, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8131), null, null, null, null, "حذف الإشعارات", 19, false },
                    { 64, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8134), null, null, null, null, "إضافة قالب الإشعارات", 20, false },
                    { 65, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8136), null, null, null, null, "عرض قالب الإشعارات", 20, false },
                    { 66, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8138), null, null, null, null, "تعديل قالب الإشعارات", 20, false },
                    { 67, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8140), null, null, null, null, "حذف قالب الإشعارات", 20, false },
                    { 68, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8142), null, null, null, null, "إضافة دور", 21, false },
                    { 69, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8144), null, null, null, null, "عرض دور", 21, false },
                    { 70, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8147), null, null, null, null, "تعديل دور", 21, false },
                    { 71, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8149), null, null, null, null, "حذف دور", 21, false },
                    { 72, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8151), null, null, null, null, "إضافة مستخدم", 22, false },
                    { 73, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8153), null, null, null, null, "عرض مستخدم", 22, false },
                    { 74, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8154), null, null, null, null, "تعديل مستخدم", 22, false },
                    { 75, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8156), null, null, null, null, "حذف مستخدم", 22, false },
                    { 76, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8159), null, null, null, null, "إضافة منسق", 23, false },
                    { 77, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8161), null, null, null, null, "عرض منسق", 23, false },
                    { 78, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8163), null, null, null, null, "تعديل منسق", 23, false },
                    { 79, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8165), null, null, null, null, "حذف منسق", 23, false },
                    { 80, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8166), null, null, null, null, "إضافة محكم", 24, false },
                    { 81, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8169), null, null, null, null, "عرض محكم", 24, false },
                    { 82, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8171), null, null, null, null, "تعديل محكم", 24, false },
                    { 83, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8173), null, null, null, null, "حذف محكم", 24, false },
                    { 84, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8175), null, null, null, null, "إضافة لجنة", 25, false },
                    { 85, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8177), null, null, null, null, "عرض لجنة", 25, false },
                    { 86, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8179), null, null, null, null, "تعديل لجنة", 25, false },
                    { 87, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8181), null, null, null, null, "حذف لجنة", 25, false },
                    { 88, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8183), null, null, null, null, "إضافة حساب المشترك", 26, false },
                    { 89, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8185), null, null, null, null, "عرض حساب المشترك", 26, false },
                    { 90, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8187), null, null, null, null, "تعديل حساب المشترك", 26, false },
                    { 91, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8189), null, null, null, null, "حذف حساب المشترك", 26, false },
                    { 92, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8191), null, null, null, null, "عرض ملف المشترك", 27, false },
                    { 93, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8193), null, null, null, null, "عرض إستمارة المشترك", 28, false },
                    { 94, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8195), null, null, null, null, "حذف إستمارة المشترك", 28, false },
                    { 95, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8206), null, null, null, null, "إضافة فعالية", 29, false },
                    { 96, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8208), null, null, null, null, "عرض فعالية", 29, false },
                    { 97, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8210), null, null, null, null, "تعديل فعالية", 29, false },
                    { 98, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8212), null, null, null, null, "حذف فعالية", 29, false },
                    { 99, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8214), null, null, null, null, "عرض رسالة تواصل", 30, false },
                    { 100, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8216), null, null, null, null, "حذف رسالة تواصل", 30, false },
                    { 101, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8218), null, null, null, null, "عرض رسالة توضيحية", 31, false },
                    { 102, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8220), null, null, null, null, "تعديل رسالة توضيحية", 31, false },
                    { 103, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8222), null, null, null, null, "إضافة مسؤولية", 32, false },
                    { 104, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8224), null, null, null, null, "عرض مسؤولية", 32, false },
                    { 105, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8226), null, null, null, null, "تعديل مسؤولية", 32, false },
                    { 106, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8228), null, null, null, null, "حذف مسؤولية", 32, false }
                });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 948, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 31, 7, 37, 59, 947, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Action", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "PermissionHeaderId", "isDeleted" },
                values: new object[,]
                {
                    { 107, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8230), null, null, null, null, "إضافة الأسئلة الشائعة العامة", 33, false },
                    { 108, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8232), null, null, null, null, "عرض الأسئلة الشائعة العامة", 33, false },
                    { 109, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8234), null, null, null, null, "تعديل الأسئلة الشائعة العامة", 33, false },
                    { 110, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8236), null, null, null, null, "حذف الأسئلة الشائعة العامة", 33, false },
                    { 111, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8238), null, null, null, null, "إضافة فئة الأسئلة الشائعة", 34, false },
                    { 112, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8240), null, null, null, null, "عرض فئة الأسئلة الشائعة", 34, false },
                    { 113, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8242), null, null, null, null, "تعديل فئة الأسئلة الشائعة", 34, false },
                    { 114, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8244), null, null, null, null, "حذف فئة الأسئلة الشائعة", 34, false },
                    { 115, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8246), null, null, null, null, "إضافة إحصائيات الجائزة", 35, false },
                    { 116, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8248), null, null, null, null, "عرض إحصائيات الجائزة", 35, false },
                    { 117, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8250), null, null, null, null, "تعديل إحصائيات الجائزة", 35, false },
                    { 118, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8252), null, null, null, null, "حذف إحصائيات الجائزة", 35, false },
                    { 119, "create", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8254), null, null, null, null, "إضافة شرائح", 36, false },
                    { 120, "read", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8256), null, null, null, null, "عرض شرائح", 36, false },
                    { 121, "update", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8258), null, null, null, null, "تعديل شرائح", 36, false },
                    { 122, "delete", new DateTime(2024, 7, 31, 7, 37, 59, 946, DateTimeKind.Utc).AddTicks(8260), null, null, null, null, "حذف شرائح", 36, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6663), new DateTime(2024, 8, 5, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6679), new DateTime(2024, 8, 9, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6678), new DateTime(2024, 8, 4, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6681), new DateTime(2024, 8, 11, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6685), new DateTime(2024, 8, 15, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6683), new DateTime(2024, 8, 10, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6686), new DateTime(2024, 8, 17, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6690), new DateTime(2024, 8, 21, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6688), new DateTime(2024, 8, 16, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6692), new DateTime(2024, 8, 23, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6695), new DateTime(2024, 8, 27, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6693), new DateTime(2024, 8, 22, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6696), new DateTime(2024, 8, 29, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6699), new DateTime(2024, 9, 2, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6698), new DateTime(2024, 8, 28, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3991), new DateTime(2024, 8, 4, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3994), new DateTime(2024, 8, 1, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4004), new DateTime(2024, 8, 2, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4008), new DateTime(2024, 8, 7, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4010), new DateTime(2024, 8, 4, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4011), new DateTime(2024, 8, 5, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4542), new DateTime(2024, 8, 9, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4545), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4739), new DateTime(2024, 8, 19, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4741), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7015));
        }
    }
}
