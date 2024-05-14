using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Arbitrations_AddNewColumn_DateOfArbitration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfArbitration",
                table: "Arbitrations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2245), new DateTime(2024, 5, 24, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2259), new DateTime(2024, 5, 19, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2283), new DateTime(2024, 5, 29, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2287), new DateTime(2024, 5, 24, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2295), new DateTime(2024, 6, 3, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2299), new DateTime(2024, 5, 29, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2305), new DateTime(2024, 6, 8, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 6, 3, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2317), new DateTime(2024, 6, 13, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2322), new DateTime(2024, 6, 8, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3764), new DateTime(2024, 5, 14, 10, 56, 48, 922, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3945), new DateTime(2024, 5, 14, 10, 56, 48, 922, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3963), new DateTime(2024, 5, 14, 10, 56, 48, 922, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3988), new DateTime(2024, 5, 14, 10, 56, 48, 922, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5604), new DateTime(2024, 5, 19, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5611), new DateTime(2024, 5, 16, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5628), new DateTime(2024, 5, 17, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5637), new DateTime(2024, 5, 22, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5641), new DateTime(2024, 5, 19, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5645), new DateTime(2024, 5, 20, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8115), new DateTime(2024, 5, 24, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8125), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8502), new DateTime(2024, 6, 3, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8512), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3173));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfArbitration",
                table: "Arbitrations");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7572), new DateTime(2024, 5, 23, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7585), new DateTime(2024, 5, 18, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7605), new DateTime(2024, 5, 28, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7609), new DateTime(2024, 5, 23, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7615), new DateTime(2024, 6, 2, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7619), new DateTime(2024, 5, 28, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7625), new DateTime(2024, 6, 7, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7628), new DateTime(2024, 6, 2, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7634), new DateTime(2024, 6, 12, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7638), new DateTime(2024, 6, 7, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8558), new DateTime(2024, 5, 13, 17, 13, 39, 972, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8689), new DateTime(2024, 5, 13, 17, 13, 39, 972, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8702), new DateTime(2024, 5, 13, 17, 13, 39, 972, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8714), new DateTime(2024, 5, 13, 17, 13, 39, 972, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8402), new DateTime(2024, 5, 18, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8410), new DateTime(2024, 5, 15, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8425), new DateTime(2024, 5, 16, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8433), new DateTime(2024, 5, 21, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 5, 18, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8441), new DateTime(2024, 5, 19, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(9954), new DateTime(2024, 5, 23, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(9964), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 6, 2, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(365), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8170));
        }
    }
}
