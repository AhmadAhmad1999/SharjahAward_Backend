using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Arbitration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "isAcceptedFromChairman",
                table: "Arbitrations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "isAccepted",
                table: "Arbitrations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3372), new DateTime(2024, 7, 22, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3379), new DateTime(2024, 7, 26, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3378), new DateTime(2024, 7, 21, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3408), new DateTime(2024, 7, 28, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3411), new DateTime(2024, 8, 1, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3409), new DateTime(2024, 7, 27, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3412), new DateTime(2024, 8, 3, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3414), new DateTime(2024, 8, 7, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3413), new DateTime(2024, 8, 2, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 8, 9, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3418), new DateTime(2024, 8, 13, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 8, 8, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3419), new DateTime(2024, 8, 15, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3421), new DateTime(2024, 8, 19, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3420), new DateTime(2024, 8, 14, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8719), new DateTime(2024, 7, 21, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8722), new DateTime(2024, 7, 18, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8731), new DateTime(2024, 7, 19, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8733), new DateTime(2024, 7, 24, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8734), new DateTime(2024, 7, 21, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 7, 22, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9097), new DateTime(2024, 7, 26, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9101), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9121), new DateTime(2024, 8, 5, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(9123), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 794, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 16, 7, 33, 58, 795, DateTimeKind.Utc).AddTicks(3568));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isAcceptedFromChairman",
                table: "Arbitrations",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "isAccepted",
                table: "Arbitrations",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4440), new DateTime(2024, 7, 20, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 7, 24, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4449), new DateTime(2024, 7, 19, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4452), new DateTime(2024, 7, 26, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4456), new DateTime(2024, 7, 30, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4454), new DateTime(2024, 7, 25, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4458), new DateTime(2024, 8, 1, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4461), new DateTime(2024, 8, 5, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4459), new DateTime(2024, 7, 31, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4463), new DateTime(2024, 8, 7, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4466), new DateTime(2024, 8, 11, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4464), new DateTime(2024, 8, 6, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4467), new DateTime(2024, 8, 13, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4470), new DateTime(2024, 8, 17, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4469), new DateTime(2024, 8, 12, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7130), new DateTime(2024, 7, 19, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7134), new DateTime(2024, 7, 16, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7143), new DateTime(2024, 7, 17, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7146), new DateTime(2024, 7, 22, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7149), new DateTime(2024, 7, 19, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7150), new DateTime(2024, 7, 20, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7783), new DateTime(2024, 7, 24, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7790), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7818), new DateTime(2024, 8, 3, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(7820), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 675, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 14, 12, 27, 49, 676, DateTimeKind.Utc).AddTicks(4664));
        }
    }
}
