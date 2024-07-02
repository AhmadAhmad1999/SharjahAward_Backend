using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addOrderIdForCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "orderId",
                table: "TextCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "orderId",
                table: "ParagraphCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PageStructureId",
                table: "ImageCards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "orderId",
                table: "ImageCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "orderId",
                table: "DarkCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 7, 12, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3977), new DateTime(2024, 7, 22, 12, 8, 23, 126, DateTimeKind.Utc).AddTicks(3979) });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageCards_PageStructures_PageStructureId",
                table: "ImageCards");

            migrationBuilder.DropIndex(
                name: "IX_ImageCards_PageStructureId",
                table: "ImageCards");

            migrationBuilder.DropColumn(
                name: "orderId",
                table: "TextCards");

            migrationBuilder.DropColumn(
                name: "orderId",
                table: "ParagraphCards");

            migrationBuilder.DropColumn(
                name: "PageStructureId",
                table: "ImageCards");

            migrationBuilder.DropColumn(
                name: "orderId",
                table: "ImageCards");

            migrationBuilder.DropColumn(
                name: "orderId",
                table: "DarkCards");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4793), new DateTime(2024, 7, 8, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4803), new DateTime(2024, 7, 12, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4802), new DateTime(2024, 7, 7, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4804), new DateTime(2024, 7, 14, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4807), new DateTime(2024, 7, 18, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4806), new DateTime(2024, 7, 13, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4808), new DateTime(2024, 7, 20, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4811), new DateTime(2024, 7, 24, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4810), new DateTime(2024, 7, 19, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4812), new DateTime(2024, 7, 26, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4815), new DateTime(2024, 7, 30, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4813), new DateTime(2024, 7, 25, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4816), new DateTime(2024, 8, 1, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4819), new DateTime(2024, 8, 5, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 7, 31, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5077), new DateTime(2024, 7, 2, 11, 19, 43, 295, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5096), new DateTime(2024, 7, 2, 11, 19, 43, 295, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5098), new DateTime(2024, 7, 2, 11, 19, 43, 295, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5100), new DateTime(2024, 7, 2, 11, 19, 43, 295, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 7, 7, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5863), new DateTime(2024, 7, 4, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5869), new DateTime(2024, 7, 5, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5872), new DateTime(2024, 7, 10, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5874), new DateTime(2024, 7, 7, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5875), new DateTime(2024, 7, 8, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6326), new DateTime(2024, 7, 12, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6453), new DateTime(2024, 7, 22, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4975));
        }
    }
}
