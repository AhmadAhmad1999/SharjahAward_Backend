using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_FinalArbitration_V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isAcceptedFromChairman",
                table: "FinalArbitrations",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfArbitration",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "FullScore",
                table: "FinalArbitrations",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "FinalArbitrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isAccepted",
                table: "FinalArbitrations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2853), new DateTime(2024, 5, 31, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2869), new DateTime(2024, 5, 26, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2906), new DateTime(2024, 6, 5, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2909), new DateTime(2024, 5, 31, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2913), new DateTime(2024, 6, 10, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2916), new DateTime(2024, 6, 5, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2920), new DateTime(2024, 6, 15, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2923), new DateTime(2024, 6, 10, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2927), new DateTime(2024, 6, 20, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2929), new DateTime(2024, 6, 15, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4133), new DateTime(2024, 5, 21, 11, 53, 46, 678, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4251), new DateTime(2024, 5, 21, 11, 53, 46, 678, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4270), new DateTime(2024, 5, 21, 11, 53, 46, 678, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4279), new DateTime(2024, 5, 21, 11, 53, 46, 678, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5551), new DateTime(2024, 5, 26, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5559), new DateTime(2024, 5, 23, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5576), new DateTime(2024, 5, 24, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5581), new DateTime(2024, 5, 29, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5584), new DateTime(2024, 5, 26, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5585), new DateTime(2024, 5, 27, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(7324), new DateTime(2024, 5, 31, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(7331), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(7771), new DateTime(2024, 6, 10, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(7774), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 675, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 8, 53, 46, 678, DateTimeKind.Utc).AddTicks(3856));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfArbitration",
                table: "FinalArbitrations");

            migrationBuilder.DropColumn(
                name: "FullScore",
                table: "FinalArbitrations");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "FinalArbitrations");

            migrationBuilder.DropColumn(
                name: "isAccepted",
                table: "FinalArbitrations");

            migrationBuilder.AlterColumn<bool>(
                name: "isAcceptedFromChairman",
                table: "FinalArbitrations",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3200), new DateTime(2024, 5, 30, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3212), new DateTime(2024, 5, 25, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3229), new DateTime(2024, 6, 4, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3234), new DateTime(2024, 5, 30, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3237), new DateTime(2024, 6, 9, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3239), new DateTime(2024, 6, 4, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3244), new DateTime(2024, 6, 14, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3246), new DateTime(2024, 6, 9, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3251), new DateTime(2024, 6, 19, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3253), new DateTime(2024, 6, 14, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3943), new DateTime(2024, 5, 20, 10, 48, 6, 603, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4060), new DateTime(2024, 5, 20, 10, 48, 6, 603, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4082), new DateTime(2024, 5, 20, 10, 48, 6, 603, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 5, 20, 10, 48, 6, 603, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2045), new DateTime(2024, 5, 25, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 5, 22, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2062), new DateTime(2024, 5, 23, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2067), new DateTime(2024, 5, 28, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2069), new DateTime(2024, 5, 25, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2071), new DateTime(2024, 5, 26, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3086), new DateTime(2024, 5, 30, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3091), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3318), new DateTime(2024, 6, 9, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3321), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3695));
        }
    }
}
