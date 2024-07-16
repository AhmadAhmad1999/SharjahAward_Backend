using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Arbitrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isAccepted",
                table: "Arbitrations",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isAccepted",
                table: "Arbitrations",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 7, 15, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4094), new DateTime(2024, 7, 19, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4092), new DateTime(2024, 7, 14, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4098), new DateTime(2024, 7, 21, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4101), new DateTime(2024, 7, 25, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4099), new DateTime(2024, 7, 20, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4102), new DateTime(2024, 7, 27, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4105), new DateTime(2024, 7, 31, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4104), new DateTime(2024, 7, 26, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4107), new DateTime(2024, 8, 2, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4110), new DateTime(2024, 8, 6, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4108), new DateTime(2024, 8, 1, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4111), new DateTime(2024, 8, 8, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4114), new DateTime(2024, 8, 12, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4113), new DateTime(2024, 8, 7, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 7, 14, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9358), new DateTime(2024, 7, 11, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9366), new DateTime(2024, 7, 12, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9368), new DateTime(2024, 7, 17, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 7, 14, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9370), new DateTime(2024, 7, 15, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9663), new DateTime(2024, 7, 19, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9669), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9731), new DateTime(2024, 7, 29, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9733), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 790, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 9, 12, 10, 23, 791, DateTimeKind.Utc).AddTicks(4397));
        }
    }
}
