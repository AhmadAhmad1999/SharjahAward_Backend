using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_Criterions_CriterionItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttachmentType",
                table: "Criterions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttachmentType",
                table: "CriterionItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 6, 23, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(911), new DateTime(2024, 6, 18, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(933), new DateTime(2024, 6, 28, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(937), new DateTime(2024, 6, 23, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(944), new DateTime(2024, 7, 3, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 6, 28, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 7, 8, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 7, 3, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 7, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(968), new DateTime(2024, 7, 8, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AttachmentType", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2206), new DateTime(2024, 6, 13, 14, 1, 9, 344, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 6, 13, 14, 1, 9, 344, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2422), new DateTime(2024, 6, 13, 14, 1, 9, 344, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2616), new DateTime(2024, 6, 13, 14, 1, 9, 344, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 6, 18, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(1970), new DateTime(2024, 6, 15, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(1993), new DateTime(2024, 6, 16, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(2003), new DateTime(2024, 6, 21, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(2008), new DateTime(2024, 6, 18, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(2011), new DateTime(2024, 6, 19, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(3810), new DateTime(2024, 6, 23, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 7, 3, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1725));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentType",
                table: "Criterions");

            migrationBuilder.DropColumn(
                name: "AttachmentType",
                table: "CriterionItems");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 218, DateTimeKind.Utc).AddTicks(9994), new DateTime(2024, 6, 23, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3), new DateTime(2024, 6, 18, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(22), new DateTime(2024, 6, 28, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(25), new DateTime(2024, 6, 23, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(28), new DateTime(2024, 7, 3, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(31), new DateTime(2024, 6, 28, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(36), new DateTime(2024, 7, 8, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(38), new DateTime(2024, 7, 3, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(41), new DateTime(2024, 7, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(43), new DateTime(2024, 7, 8, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1188), new DateTime(2024, 6, 13, 13, 28, 6, 219, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1316), new DateTime(2024, 6, 13, 13, 28, 6, 219, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1334), new DateTime(2024, 6, 13, 13, 28, 6, 219, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1341), new DateTime(2024, 6, 13, 13, 28, 6, 219, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2924), new DateTime(2024, 6, 18, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2928), new DateTime(2024, 6, 15, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2943), new DateTime(2024, 6, 16, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2947), new DateTime(2024, 6, 21, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2950), new DateTime(2024, 6, 18, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2951), new DateTime(2024, 6, 19, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(3755), new DateTime(2024, 6, 23, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(3991), new DateTime(2024, 7, 3, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 217, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 10, 28, 6, 219, DateTimeKind.Utc).AddTicks(933));
        }
    }
}
