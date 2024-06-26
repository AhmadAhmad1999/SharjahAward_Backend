using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditOnPageStruct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "PageStructures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3799), new DateTime(2024, 7, 2, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 7, 6, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3806), new DateTime(2024, 7, 1, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3808), new DateTime(2024, 7, 8, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 7, 12, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3809), new DateTime(2024, 7, 7, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 7, 14, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 7, 18, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 7, 13, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 7, 20, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 7, 24, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3818), new DateTime(2024, 7, 19, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3821), new DateTime(2024, 7, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3823), new DateTime(2024, 7, 30, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3822), new DateTime(2024, 7, 25, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4188), new DateTime(2024, 6, 26, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4216), new DateTime(2024, 6, 26, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4218), new DateTime(2024, 6, 26, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 6, 26, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4300), new DateTime(2024, 7, 1, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4304), new DateTime(2024, 6, 28, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 6, 29, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4313), new DateTime(2024, 7, 4, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4315), new DateTime(2024, 7, 1, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4317), new DateTime(2024, 7, 2, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4792), new DateTime(2024, 7, 6, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4955), new DateTime(2024, 7, 16, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.InsertData(
                table: "PermissionHeaders",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 31, new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4992), null, null, null, null, "ExplanatoryMessage", false },
                    { 32, new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4993), null, null, null, null, "Responsibility", false }
                });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3721), "تعديل حول الجائزة", 1 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3736), "إضافة معرض الصور", 2 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3739), "عرض معرض الصور", 2 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3741), "تعديل معرض الصور", 2 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3744), "حذف معرض الصور", 2 });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "PermissionHeaderId", "isDeleted" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3746), null, null, null, null, "إضافة نسخة التطبيق", 3, false },
                    { 7, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3748), null, null, null, null, "عرض نسخة التطبيق", 3, false },
                    { 8, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3750), null, null, null, null, "إضافة إصدارات الجائزة", 4, false },
                    { 9, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3753), null, null, null, null, "عرض إصدارات الجائزة", 4, false },
                    { 10, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3755), null, null, null, null, "تعديل إصدارات الجائزة", 4, false },
                    { 11, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3757), null, null, null, null, "حذف إصدارات الجائزة", 4, false },
                    { 12, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3759), null, null, null, null, "تعديل راعي الجائزة", 5, false },
                    { 13, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3761), null, null, null, null, "إضافة التعاميم", 6, false },
                    { 14, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3763), null, null, null, null, "عرض التعاميم", 6, false },
                    { 15, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3765), null, null, null, null, "تعديل التعاميم", 6, false },
                    { 16, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3768), null, null, null, null, "حذف التعاميم", 6, false },
                    { 17, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3770), null, null, null, null, "إضافة الصفوف", 7, false },
                    { 18, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3772), null, null, null, null, "عرض الصفوف", 7, false },
                    { 19, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3774), null, null, null, null, "تعديل الصفوف", 7, false },
                    { 20, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3776), null, null, null, null, "حذف الصفوف", 7, false },
                    { 21, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3778), null, null, null, null, "إضافة محكم صف", 8, false },
                    { 22, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3781), null, null, null, null, "عرض محكم صف", 8, false },
                    { 23, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3783), null, null, null, null, "حذف محكم صف", 8, false },
                    { 24, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3785), null, null, null, null, "عرض الدورات", 9, false },
                    { 25, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3787), null, null, null, null, "إضافة دورة", 9, false },
                    { 26, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3789), null, null, null, null, "عرض معلومات دورة", 9, false },
                    { 27, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3791), null, null, null, null, "تعديل دورة", 9, false },
                    { 28, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3793), null, null, null, null, "حذف دورة", 9, false },
                    { 29, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3795), null, null, null, null, "إضافة أجندة", 10, false },
                    { 30, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3798), null, null, null, null, "عرض أجندة", 10, false },
                    { 31, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3800), null, null, null, null, "تعديل أجندة", 10, false },
                    { 32, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3802), null, null, null, null, "حذف أجندة", 10, false },
                    { 33, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3804), null, null, null, null, "إضافة فئات", 11, false },
                    { 34, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3807), null, null, null, null, "عرض فئات", 11, false },
                    { 35, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3809), null, null, null, null, "تعديل فئات", 11, false },
                    { 36, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3811), null, null, null, null, "حذف فئات", 11, false },
                    { 37, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3813), null, null, null, null, "إضافة شروط عامة", 12, false },
                    { 38, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3816), null, null, null, null, "عرض شروط عامة", 12, false },
                    { 39, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3818), null, null, null, null, "تعديل شروط عامة", 12, false },
                    { 40, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3820), null, null, null, null, "حذف شروط عامة", 12, false },
                    { 41, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3822), null, null, null, null, "إضافة جهات تعليمية", 13, false },
                    { 42, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3824), null, null, null, null, "عرض جهات تعليمية", 13, false },
                    { 43, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3826), null, null, null, null, "تعديل جهات تعليمية", 13, false },
                    { 44, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3828), null, null, null, null, "حذف جهات تعليمية", 13, false },
                    { 45, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3831), null, null, null, null, "عرض ملفات النظام", 14, false },
                    { 46, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3833), null, null, null, null, "إضافة ورش تدريبية عامة", 15, false },
                    { 47, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3835), null, null, null, null, "عرض ورش تدريبية عامة", 15, false },
                    { 48, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3837), null, null, null, null, "تعديل ورش تدريبية عامة", 15, false },
                    { 49, new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3839), null, null, null, null, "حذف ورش تدريبية عامة", 15, false }
                });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4060));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "PageStructures");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8544), new DateTime(2024, 7, 2, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8587), new DateTime(2024, 7, 6, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8585), new DateTime(2024, 7, 1, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8591), new DateTime(2024, 7, 8, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8598), new DateTime(2024, 7, 12, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8594), new DateTime(2024, 7, 7, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8601), new DateTime(2024, 7, 14, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8608), new DateTime(2024, 7, 18, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8604), new DateTime(2024, 7, 13, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8610), new DateTime(2024, 7, 20, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8617), new DateTime(2024, 7, 24, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8613), new DateTime(2024, 7, 19, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8620), new DateTime(2024, 7, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8627), new DateTime(2024, 7, 30, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8623), new DateTime(2024, 7, 25, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9785), new DateTime(2024, 6, 26, 15, 33, 40, 578, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9963), new DateTime(2024, 6, 26, 15, 33, 40, 578, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3), new DateTime(2024, 6, 26, 15, 33, 40, 579, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(29), new DateTime(2024, 6, 26, 15, 33, 40, 579, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(4672), new DateTime(2024, 7, 1, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(4678), new DateTime(2024, 6, 28, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(4725), new DateTime(2024, 6, 29, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(4731), new DateTime(2024, 7, 4, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(4734), new DateTime(2024, 7, 1, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(4737), new DateTime(2024, 7, 2, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7210), new DateTime(2024, 7, 6, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7626), new DateTime(2024, 7, 16, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3716), "عرض الدورات", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3726), "إضافة دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3730), "عرض معلومات دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3734), "تعديل دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3738), "حذف دورة", 9 });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 579, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 578, DateTimeKind.Utc).AddTicks(9325));
        }
    }
}
