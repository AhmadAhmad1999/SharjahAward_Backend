using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_DynamicAttributeSections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 7, 4, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8443), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8691), new DateTime(2024, 7, 14, 11, 11, 51, 549, DateTimeKind.Utc).AddTicks(8694), "Sunday" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(4846), new DateTime(2024, 7, 3, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(4854), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5052), new DateTime(2024, 7, 13, 9, 22, 23, 756, DateTimeKind.Utc).AddTicks(5054), "Saturday" });

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
    }
}
