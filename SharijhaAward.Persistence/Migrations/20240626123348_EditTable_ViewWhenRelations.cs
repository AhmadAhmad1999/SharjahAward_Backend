using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_ViewWhenRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ViewWhenRelations_DynamicAttributes_DynamicAttributeId",
                table: "ViewWhenRelations");

            migrationBuilder.AlterColumn<int>(
                name: "DynamicAttributeId",
                table: "ViewWhenRelations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DynamicAttributeSectionId",
                table: "ViewWhenRelations",
                type: "int",
                nullable: true);

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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7210), new DateTime(2024, 7, 6, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7219), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7626), new DateTime(2024, 7, 16, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(7630), "Tuesday" });

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
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 33, 40, 575, DateTimeKind.Utc).AddTicks(3738));

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

            migrationBuilder.CreateIndex(
                name: "IX_ViewWhenRelations_DynamicAttributeSectionId",
                table: "ViewWhenRelations",
                column: "DynamicAttributeSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ViewWhenRelations_DynamicAttributeSections_DynamicAttributeSectionId",
                table: "ViewWhenRelations",
                column: "DynamicAttributeSectionId",
                principalTable: "DynamicAttributeSections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ViewWhenRelations_DynamicAttributes_DynamicAttributeId",
                table: "ViewWhenRelations",
                column: "DynamicAttributeId",
                principalTable: "DynamicAttributes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ViewWhenRelations_DynamicAttributeSections_DynamicAttributeSectionId",
                table: "ViewWhenRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_ViewWhenRelations_DynamicAttributes_DynamicAttributeId",
                table: "ViewWhenRelations");

            migrationBuilder.DropIndex(
                name: "IX_ViewWhenRelations_DynamicAttributeSectionId",
                table: "ViewWhenRelations");

            migrationBuilder.DropColumn(
                name: "DynamicAttributeSectionId",
                table: "ViewWhenRelations");

            migrationBuilder.AlterColumn<int>(
                name: "DynamicAttributeId",
                table: "ViewWhenRelations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2022), new DateTime(2024, 7, 1, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2049), new DateTime(2024, 7, 5, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2047), new DateTime(2024, 6, 30, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2052), new DateTime(2024, 7, 7, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2061), new DateTime(2024, 7, 11, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2058), new DateTime(2024, 7, 6, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2063), new DateTime(2024, 7, 13, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2068), new DateTime(2024, 7, 17, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2065), new DateTime(2024, 7, 12, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2071), new DateTime(2024, 7, 19, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2077), new DateTime(2024, 7, 23, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2074), new DateTime(2024, 7, 18, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2079), new DateTime(2024, 7, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2085), new DateTime(2024, 7, 29, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2082), new DateTime(2024, 7, 24, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2773), new DateTime(2024, 6, 25, 16, 42, 49, 67, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2897), new DateTime(2024, 6, 25, 16, 42, 49, 67, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2917), new DateTime(2024, 6, 25, 16, 42, 49, 67, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2925), new DateTime(2024, 6, 25, 16, 42, 49, 67, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9053), new DateTime(2024, 6, 30, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9061), new DateTime(2024, 6, 27, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9112), new DateTime(2024, 6, 28, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9119), new DateTime(2024, 7, 3, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9123), new DateTime(2024, 6, 30, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9125), new DateTime(2024, 7, 1, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(163), new DateTime(2024, 7, 5, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(169), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(436), new DateTime(2024, 7, 15, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(440), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.AddForeignKey(
                name: "FK_ViewWhenRelations_DynamicAttributes_DynamicAttributeId",
                table: "ViewWhenRelations",
                column: "DynamicAttributeId",
                principalTable: "DynamicAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
