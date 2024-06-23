using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditeOnAwardPublication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwardPublications_Cycles_CycleId",
                table: "AwardPublications");

            migrationBuilder.DropIndex(
                name: "IX_AwardPublications_CycleId",
                table: "AwardPublications");

            migrationBuilder.DropColumn(
                name: "CycleId",
                table: "AwardPublications");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6258), new DateTime(2024, 7, 3, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6263), new DateTime(2024, 6, 28, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6270), new DateTime(2024, 7, 8, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6272), new DateTime(2024, 7, 3, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6274), new DateTime(2024, 7, 13, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6275), new DateTime(2024, 7, 8, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6278), new DateTime(2024, 7, 18, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6279), new DateTime(2024, 7, 13, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6282), new DateTime(2024, 7, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6283), new DateTime(2024, 7, 18, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6707), new DateTime(2024, 6, 23, 12, 22, 23, 757, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6729), new DateTime(2024, 6, 23, 12, 22, 23, 757, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6731), new DateTime(2024, 6, 23, 12, 22, 23, 757, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6734), new DateTime(2024, 6, 23, 12, 22, 23, 757, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3973), new DateTime(2024, 6, 28, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3977), new DateTime(2024, 6, 25, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3987), new DateTime(2024, 6, 26, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3990), new DateTime(2024, 7, 1, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3992), new DateTime(2024, 6, 28, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3993), new DateTime(2024, 6, 29, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(4846), new DateTime(2024, 7, 3, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5052), new DateTime(2024, 7, 13, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 9, 22, 23, 757, DateTimeKind.Utc).AddTicks(6579));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CycleId",
                table: "AwardPublications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6022), new DateTime(2024, 7, 3, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6026), new DateTime(2024, 6, 28, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6031), new DateTime(2024, 7, 8, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6036), new DateTime(2024, 7, 3, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6038), new DateTime(2024, 7, 13, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 7, 8, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6042), new DateTime(2024, 7, 18, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6043), new DateTime(2024, 7, 13, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6046), new DateTime(2024, 7, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6047), new DateTime(2024, 7, 18, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6325), new DateTime(2024, 6, 23, 11, 18, 19, 609, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6349), new DateTime(2024, 6, 23, 11, 18, 19, 609, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6351), new DateTime(2024, 6, 23, 11, 18, 19, 609, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6354), new DateTime(2024, 6, 23, 11, 18, 19, 609, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7903), new DateTime(2024, 6, 28, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7906), new DateTime(2024, 6, 25, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7913), new DateTime(2024, 6, 26, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7915), new DateTime(2024, 7, 1, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7917), new DateTime(2024, 6, 28, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7918), new DateTime(2024, 6, 29, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8261), new DateTime(2024, 7, 3, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8415), new DateTime(2024, 7, 13, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.CreateIndex(
                name: "IX_AwardPublications_CycleId",
                table: "AwardPublications",
                column: "CycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AwardPublications_Cycles_CycleId",
                table: "AwardPublications",
                column: "CycleId",
                principalTable: "Cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
