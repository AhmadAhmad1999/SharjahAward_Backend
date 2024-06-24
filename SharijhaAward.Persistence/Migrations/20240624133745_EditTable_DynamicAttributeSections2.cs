using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_DynamicAttributeSections2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxNumberOfRows",
                table: "DynamicAttributeSections",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinNumberOfRows",
                table: "DynamicAttributeSections",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6265), new DateTime(2024, 7, 4, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6272), new DateTime(2024, 6, 29, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6291), new DateTime(2024, 7, 9, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6294), new DateTime(2024, 7, 4, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6296), new DateTime(2024, 7, 14, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6299), new DateTime(2024, 7, 9, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6302), new DateTime(2024, 7, 19, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6304), new DateTime(2024, 7, 14, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6307), new DateTime(2024, 7, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6308), new DateTime(2024, 7, 19, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MaxNumberOfRows", "MinNumberOfRows" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8163), null, null });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6903), new DateTime(2024, 6, 24, 16, 37, 40, 522, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 6, 24, 16, 37, 40, 522, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 6, 24, 16, 37, 40, 522, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7057), new DateTime(2024, 6, 24, 16, 37, 40, 522, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5699), new DateTime(2024, 6, 29, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5704), new DateTime(2024, 6, 26, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5717), new DateTime(2024, 6, 27, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5723), new DateTime(2024, 7, 2, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5724), new DateTime(2024, 6, 29, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5726), new DateTime(2024, 6, 30, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6520), new DateTime(2024, 7, 4, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6778), new DateTime(2024, 7, 14, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6689));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxNumberOfRows",
                table: "DynamicAttributeSections");

            migrationBuilder.DropColumn(
                name: "MinNumberOfRows",
                table: "DynamicAttributeSections");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7078), new DateTime(2024, 7, 4, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7089), new DateTime(2024, 6, 29, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7111), new DateTime(2024, 7, 9, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7114), new DateTime(2024, 7, 4, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7141), new DateTime(2024, 7, 14, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7143), new DateTime(2024, 7, 9, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7147), new DateTime(2024, 7, 19, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7149), new DateTime(2024, 7, 14, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 7, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7156), new DateTime(2024, 7, 19, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7882), new DateTime(2024, 6, 24, 14, 11, 51, 551, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 6, 24, 14, 11, 51, 551, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8033), new DateTime(2024, 6, 24, 14, 11, 51, 551, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8041), new DateTime(2024, 6, 24, 14, 11, 51, 551, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(7195), new DateTime(2024, 6, 29, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(7200), new DateTime(2024, 6, 26, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(7215), new DateTime(2024, 6, 27, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(7221), new DateTime(2024, 7, 2, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(7223), new DateTime(2024, 6, 29, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(7225), new DateTime(2024, 6, 30, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 7, 4, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8691), new DateTime(2024, 7, 14, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 552, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 11, 11, 51, 551, DateTimeKind.Utc).AddTicks(7593));
        }
    }
}
