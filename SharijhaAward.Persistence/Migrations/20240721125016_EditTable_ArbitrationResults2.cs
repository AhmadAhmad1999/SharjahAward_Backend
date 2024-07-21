using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_ArbitrationResults2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NotifiedAsWinner",
                table: "ArbitrationResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8272), new DateTime(2024, 7, 27, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8280), new DateTime(2024, 7, 31, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8278), new DateTime(2024, 7, 26, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8282), new DateTime(2024, 8, 2, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8285), new DateTime(2024, 8, 6, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8283), new DateTime(2024, 8, 1, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8286), new DateTime(2024, 8, 8, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8289), new DateTime(2024, 8, 12, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8288), new DateTime(2024, 8, 7, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8290), new DateTime(2024, 8, 14, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8293), new DateTime(2024, 8, 18, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8291), new DateTime(2024, 8, 13, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8294), new DateTime(2024, 8, 20, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8296), new DateTime(2024, 8, 24, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8295), new DateTime(2024, 8, 19, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4067), new DateTime(2024, 7, 26, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4071), new DateTime(2024, 7, 23, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4079), new DateTime(2024, 7, 24, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4081), new DateTime(2024, 7, 29, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 7, 26, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4084), new DateTime(2024, 7, 27, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4410), new DateTime(2024, 7, 31, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4415), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 8, 10, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(4451), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 66, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 21, 12, 50, 15, 65, DateTimeKind.Utc).AddTicks(8435));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotifiedAsWinner",
                table: "ArbitrationResults");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8859), new DateTime(2024, 7, 24, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8869), new DateTime(2024, 7, 28, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8867), new DateTime(2024, 7, 23, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8871), new DateTime(2024, 7, 30, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8874), new DateTime(2024, 8, 3, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8872), new DateTime(2024, 7, 29, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8875), new DateTime(2024, 8, 5, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 8, 9, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8877), new DateTime(2024, 8, 4, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8879), new DateTime(2024, 8, 11, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8882), new DateTime(2024, 8, 15, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8881), new DateTime(2024, 8, 10, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8883), new DateTime(2024, 8, 17, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8886), new DateTime(2024, 8, 21, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8884), new DateTime(2024, 8, 16, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3688), new DateTime(2024, 7, 23, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3691), new DateTime(2024, 7, 20, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3700), new DateTime(2024, 7, 21, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3702), new DateTime(2024, 7, 26, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3704), new DateTime(2024, 7, 23, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3706), new DateTime(2024, 7, 24, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4113), new DateTime(2024, 7, 28, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4118), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 8, 7, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(4143), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 835, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 18, 11, 41, 35, 834, DateTimeKind.Utc).AddTicks(9063));
        }
    }
}
