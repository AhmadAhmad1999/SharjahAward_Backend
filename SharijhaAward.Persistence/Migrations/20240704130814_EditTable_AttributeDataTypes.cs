using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_AttributeDataTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "AttributeDataTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4480), new DateTime(2024, 7, 10, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4489), new DateTime(2024, 7, 14, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4487), new DateTime(2024, 7, 9, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4491), new DateTime(2024, 7, 16, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4494), new DateTime(2024, 7, 20, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4492), new DateTime(2024, 7, 15, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 7, 22, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 7, 26, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4496), new DateTime(2024, 7, 21, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 7, 28, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 8, 1, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4499), new DateTime(2024, 7, 27, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4502), new DateTime(2024, 8, 3, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 8, 7, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4503), new DateTime(2024, 8, 2, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "نص", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "بريد إلكتروني", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "صورة", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "ملف", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "رقم هاتف متحرك", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "رقم", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "تاريخ", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "قائمة منسدلة", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "موقع", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "رقم هوية إماراتية", new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4752), new DateTime(2024, 7, 4, 16, 8, 12, 718, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4771), new DateTime(2024, 7, 4, 16, 8, 12, 718, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4773), new DateTime(2024, 7, 4, 16, 8, 12, 718, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4775), new DateTime(2024, 7, 4, 16, 8, 12, 718, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9975), new DateTime(2024, 7, 9, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9978), new DateTime(2024, 7, 6, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9986), new DateTime(2024, 7, 7, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 7, 12, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 7, 9, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9990), new DateTime(2024, 7, 10, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(370), new DateTime(2024, 7, 14, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(410), new DateTime(2024, 7, 24, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 717, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4928), "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 13, 8, 12, 718, DateTimeKind.Utc).AddTicks(4660));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "AttributeDataTypes");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8806), new DateTime(2024, 7, 10, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 7, 14, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8822), new DateTime(2024, 7, 9, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8825), new DateTime(2024, 7, 16, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8829), new DateTime(2024, 7, 20, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8827), new DateTime(2024, 7, 15, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8831), new DateTime(2024, 7, 22, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8835), new DateTime(2024, 7, 26, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8833), new DateTime(2024, 7, 21, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8837), new DateTime(2024, 7, 28, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8842), new DateTime(2024, 8, 1, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8839), new DateTime(2024, 7, 27, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8844), new DateTime(2024, 8, 3, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8848), new DateTime(2024, 8, 7, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8845), new DateTime(2024, 8, 2, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9352), new DateTime(2024, 7, 4, 11, 0, 36, 75, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9384), new DateTime(2024, 7, 4, 11, 0, 36, 75, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 7, 4, 11, 0, 36, 75, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 7, 4, 11, 0, 36, 75, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1380), new DateTime(2024, 7, 9, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1385), new DateTime(2024, 7, 6, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1394), new DateTime(2024, 7, 7, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1397), new DateTime(2024, 7, 12, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1399), new DateTime(2024, 7, 9, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1401), new DateTime(2024, 7, 10, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2356), new DateTime(2024, 7, 14, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2562), new DateTime(2024, 7, 24, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 74, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 76, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9784), "ahmad.a.ahmad.100011@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 4, 8, 0, 36, 75, DateTimeKind.Utc).AddTicks(9154));
        }
    }
}
