using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_CriterionItemAttachments_CriterionAttachments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "CriterionItemAttachments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReasonForRejecting",
                table: "CriterionItemAttachments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "CriterionAttachments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReasonForRejecting",
                table: "CriterionAttachments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2524), new DateTime(2024, 7, 31, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2534), new DateTime(2024, 8, 4, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2533), new DateTime(2024, 7, 30, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2536), new DateTime(2024, 8, 6, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2539), new DateTime(2024, 8, 10, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2537), new DateTime(2024, 8, 5, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 8, 12, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 8, 16, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2541), new DateTime(2024, 8, 11, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2544), new DateTime(2024, 8, 18, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2547), new DateTime(2024, 8, 22, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2545), new DateTime(2024, 8, 17, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2548), new DateTime(2024, 8, 24, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 8, 28, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2549), new DateTime(2024, 8, 23, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7660), new DateTime(2024, 7, 30, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7664), new DateTime(2024, 7, 27, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7672), new DateTime(2024, 7, 28, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7676), new DateTime(2024, 8, 2, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7677), new DateTime(2024, 7, 30, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7679), new DateTime(2024, 7, 31, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8075), new DateTime(2024, 8, 4, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8122), new DateTime(2024, 8, 14, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.InsertData(
                table: "Index",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "Slug", "isDeleted" },
                values: new object[] { 1, "نوع الرسالة", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Message Type", null, null, "Message_Type", false });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 947, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 13, 48, 32, 948, DateTimeKind.Utc).AddTicks(2730));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Index",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "CriterionItemAttachments");

            migrationBuilder.DropColumn(
                name: "ReasonForRejecting",
                table: "CriterionItemAttachments");

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "CriterionAttachments");

            migrationBuilder.DropColumn(
                name: "ReasonForRejecting",
                table: "CriterionAttachments");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6413), new DateTime(2024, 7, 31, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6422), new DateTime(2024, 8, 4, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 7, 30, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 8, 6, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6427), new DateTime(2024, 8, 10, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6425), new DateTime(2024, 8, 5, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6428), new DateTime(2024, 8, 12, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6431), new DateTime(2024, 8, 16, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6429), new DateTime(2024, 8, 11, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 8, 18, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6435), new DateTime(2024, 8, 22, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6434), new DateTime(2024, 8, 17, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 8, 24, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6439), new DateTime(2024, 8, 28, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6438), new DateTime(2024, 8, 23, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7912), new DateTime(2024, 7, 30, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7915), new DateTime(2024, 7, 27, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 7, 28, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7925), new DateTime(2024, 8, 2, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7927), new DateTime(2024, 7, 30, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7928), new DateTime(2024, 7, 31, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8469), new DateTime(2024, 8, 4, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8641), new DateTime(2024, 8, 14, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6610));
        }
    }
}
