using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnAlbum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Albums",
                newName: "EnglishTitle");

            migrationBuilder.AddColumn<string>(
                name: "ArabicTitle",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3241), new DateTime(2024, 6, 19, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3244), new DateTime(2024, 6, 14, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3249), new DateTime(2024, 6, 24, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 6, 19, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 6, 29, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3254), new DateTime(2024, 6, 24, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3256), new DateTime(2024, 7, 4, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3257), new DateTime(2024, 6, 29, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3260), new DateTime(2024, 7, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3261), new DateTime(2024, 7, 4, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3629), new DateTime(2024, 6, 9, 13, 20, 13, 768, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 6, 9, 13, 20, 13, 768, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3656), new DateTime(2024, 6, 9, 13, 20, 13, 768, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3658), new DateTime(2024, 6, 9, 13, 20, 13, 768, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2572), new DateTime(2024, 6, 14, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2577), new DateTime(2024, 6, 11, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2583), new DateTime(2024, 6, 12, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2587), new DateTime(2024, 6, 17, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 6, 14, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 6, 15, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.InsertData(
                table: "ExplanatoryMessages",
                columns: new[] { "Id", "ArabicText", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishText", "LastModifiedAt", "LastModifiedBy", "Type", "isDeleted" },
                values: new object[,]
                {
                    { 1, "يمكنك البحث عن منسق لإرشادك في عملية المشاركة في الجائزة من خلال نحديد المعلومات الموجودة أدناه لتتمكن من اختيار المنسق الذي تريده.", new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5917), null, null, "You can search for a coordinator to guide you in the process of participating in the award by specifying the information below so that you can choose the coordinator you want.", null, null, 0, false },
                    { 2, "شاركنا إنجازاتك هنا، نحن نبحث عن الأفراد المميزين في مجالاتهم ليشاركونا مهاراتهم وخبراتهم.", new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5919), null, null, "Share your achievements with us here. We are looking for distinguished individuals in their fields to share their skills and experiences with us.", null, null, 1, false },
                    { 3, "يمكنك ربط حسابك مع اشخاص آخرين عن طريق إرسال دعوة لهم عن طريق البريد الالكتروني .", new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5921), null, null, "You can link your account with other people by sending them an invitation via email.", null, null, 2, false },
                    { 4, "20 يوماً باق لانتهاء مرحلة التحكيم النهائية للمشاركين.", new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5923), null, null, "20 days remain until the end of the final judging phase for the participants.", null, null, 3, false },
                    { 5, "لقد اتممت خطوات التسجيل في الجائزة   -   الرجاء الذهاب إلى المراحل الخاصة بالاستمارة لإرسال الاستمارة .", new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5925), null, null, "You have completed the steps to register for the award - please go to the application stages to submit the form.", null, null, 4, false },
                    { 6, "الرجاء إتمام جميع المراحل الخاصة بالاستمارة الجديدة لتتمكن من الاشتراك بنجاح     --  يمكن الاشتراك بفئتين فقط (فئة ذات طابع فردي وفئة ذات طابع جماعي )خلال الدورة الواحدة ورفع الملفات المطلوبة عند تعبئة الاستمارة.", new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5927), null, null, "Please complete all stages of the new form to be able to participate successfully. You can participate in only two categories (an individual category and a group category) during one session and upload the required files when filling out the form.", null, null, 5, false },
                    { 7, "الرجاء الموافقة على الشروط الخاصة كل شرط على حدا ورفع البيانات المطلوبة  في الحقول الخاصة ليتم قبول استمارة الترشح الخاصة.", new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5929), null, null, "Please agree to the special conditions one by one and upload the required data in the special fields for the special nomination form to be accepted.", null, null, 6, false },
                    { 8, "يمكنك رفع عدد غير محدود من الملفات والتعديل عليها قبل إرسال الاستمارة.", new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5931), null, null, "You can upload an unlimited number of files and modify them before submitting the form.", null, null, 7, false },
                    { 9, "عزيزي المشترك الرجاء تأكيد الموافقة على كافة المعلومات الواردة ضمن الإستمارة الخاصة بك كون هذه الخطوة غير قابلة للتراجع.", new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5933), null, null, "Dear subscriber, please confirm your approval of all the information contained in your form, as this step is irreversible.", null, null, 8, false }
                });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3092), new DateTime(2024, 6, 19, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3095), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3229), new DateTime(2024, 6, 29, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3231), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3511));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "ArabicTitle",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "EnglishTitle",
                table: "Albums",
                newName: "Title");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1169), new DateTime(2024, 6, 16, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1173), new DateTime(2024, 6, 11, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1179), new DateTime(2024, 6, 21, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1181), new DateTime(2024, 6, 16, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1183), new DateTime(2024, 6, 26, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1185), new DateTime(2024, 6, 21, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 7, 1, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1189), new DateTime(2024, 6, 26, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 7, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 7, 1, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1623), new DateTime(2024, 6, 6, 11, 8, 49, 771, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1645), new DateTime(2024, 6, 6, 11, 8, 49, 771, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1648), new DateTime(2024, 6, 6, 11, 8, 49, 771, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1651), new DateTime(2024, 6, 6, 11, 8, 49, 771, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(303), new DateTime(2024, 6, 11, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(306), new DateTime(2024, 6, 8, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(313), new DateTime(2024, 6, 9, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(317), new DateTime(2024, 6, 14, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(319), new DateTime(2024, 6, 11, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(320), new DateTime(2024, 6, 12, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(800), new DateTime(2024, 6, 16, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(803), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 6, 26, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(982), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1475));
        }
    }
}
